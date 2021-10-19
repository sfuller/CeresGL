import glob
import json
import os
import sys
from typing import List

import gl
import gengl


class Vertex(object):
    def __init__(self):
        self.namespace = ''
        self.name = ''
        self.attributes: List[Attribute] = []


class Attribute(object):
    def __init__(self):
        self.name = ''
        self.type = ''
        self.count = 0
        self.normalized = False


def main():
    # TODO: Argparser
    os.chdir(sys.argv[1])
    paths = glob.glob('**/buffers.json', recursive=True)
    print(f'{len(paths)} buffer definition file(s) found.')
    for path in paths:
        generate_buffers(path)


def generate_buffers(bufferfile_path: str) -> None:
    print(f'Generating buffers for {bufferfile_path}')

    with open(bufferfile_path, encoding='utf-8-sig') as f:
        root = json.load(f)

    vertices: List[Vertex] = []
    for buffer_data in root:
        vertex = Vertex()
        vertex.name = buffer_data['name']
        vertex.namespace = buffer_data['namespace']

        for attribute_data in buffer_data['attributes']:
            attrib = Attribute()
            attrib.name = attribute_data['name']
            attrib.type = attribute_data['type']
            attrib.count = int(attribute_data['count'])
            attrib.normalized = bool(attribute_data['normalized'])
            vertex.attributes.append(attrib)

        vertices.append(vertex)

    for vertex in vertices:
        code = gen_buffer(vertex)
        namespace_parts = vertex.namespace.split('.')
        project_path = os.path.join(*namespace_parts)
        os.makedirs(project_path, exist_ok=True)
        with open(os.path.join(project_path, f'{vertex.name}.Generated.cs'), 'w') as f:
            f.write(code)


def gen_buffer(vertex: Vertex) -> str:
    parts: List[str] = []

    # Validate buffer counts
    for attrib in vertex.attributes:
        if attrib.count < 1 or attrib.count > 4:
            raise ValueError(f'Invalid count of components for attribute {attrib.name} in vertex {attrib.name}. '
                             'Must be 1, 2, 3, or 4.')

    element_size = sum(gl.get_byte_size_of_vertex_attrib_type(a.type) * a.count for a in vertex.attributes)
    max_component_size = max(gl.get_byte_size_of_vertex_attrib_type(a.type) for a in vertex.attributes)

    # Using statements
    parts.append(f'''using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using {gengl.NAMESPACE};

''')

    # Begin Namespace
    parts.append(f'namespace {vertex.namespace}\n{{\n')

    # Begin Vertex struct
    parts.append(f'''    [GeneratedCode("genbuffers.py", "0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct {vertex.name}
    {{
''')

    # Generate vertex fields
    current_attrib_offset = 0
    for attrib in vertex.attributes:
        for i in range(attrib.count):
            parts.append(
                f'        [FieldOffset({current_attrib_offset})] public {gl.get_cs_type_for_vertex_attrib_type(attrib.type)} {attrib.name}_{i};\n')
            current_attrib_offset += gl.get_byte_size_of_vertex_attrib_type(attrib.type)

    # End Vertex Struct
    parts.append('    }\n\n')

    # Begin Namespace and Buffer class
    parts.append(f'''    [GeneratedCode("genbuffers.py", "0")]
    public static class {vertex.name}Buffer
    {{
        public static unsafe void BufferData(GL gl, BufferTargetARB target, Span<{vertex.name}> vertices, BufferUsageARB usage)
        {{
            fixed (void* dataPtr = vertices) {{
                gl.glBufferData((uint)target, new IntPtr({element_size} * vertices.Length), (IntPtr)dataPtr, (uint)usage);
            }}
        }}

        public static void BufferData(GL gl, BufferTargetARB target, uint vertexCount, BufferUsageARB usage)
        {{
            gl.BufferData(target, {element_size} * vertexCount, usage);
        }}

        public static unsafe void BufferSubData(GL gl, BufferTargetARB target, uint startVertex, Span<{vertex.name}> vertices)
        {{
            fixed (void* dataPtr = vertices) {{
                gl.glBufferSubData((uint)target, new IntPtr({element_size} * startVertex), (IntPtr)({element_size} * vertices.Length), (IntPtr)dataPtr);
            }}
        }}

''')

    # Begin SetupVertexAttributes Method Opening
    parts.append('        public static void SetupVertexAttributes(GL gl')

    # Generate SetupVertexAttributes index parameters
    for attrib in vertex.attributes:
        parts.append(f', uint {attrib.name}_location')

    # Finish SetupVertexAttributes Method Opening
    parts.append(')\n        {\n')

    # Generate SetupVertexAttributes Method Body
    current_attrib_offset = 0
    for attrib in vertex.attributes:
        normalized = 'true' if attrib.normalized else 'false'
        type_arg = f'(uint)VertexAttribPointerType.{gl.get_abbreviated_enum_name(attrib.type)}'
        parts.append(
            '            '
            f'gl.glVertexAttribPointer({attrib.name}_location, {attrib.count}, {type_arg}, {normalized}, {element_size}, new IntPtr({current_attrib_offset}));\n')

        current_attrib_offset += gl.get_byte_size_of_vertex_attrib_type(attrib.type) * attrib.count

    for attrib in vertex.attributes:
        parts.append(f'            gl.EnableVertexAttribArray({attrib.name}_location);\n')

    # End SetupVertexAttributes Method
    parts.append('        }\n')

    # End Buffer Class
    parts.append('    }\n')

    # End namespace
    parts.append('}\n')

    return ''.join(parts)


if __name__ == '__main__':
    main()
