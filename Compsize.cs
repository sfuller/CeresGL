using System;

namespace CeresGL
{
    public static class Compsize
    {
        public static int glGetInteger64v_data(GetPName pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glClearBufferuiv_value(Buffer buffer)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetQueryObjectui64v_params(QueryObjectParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetMultisamplefv_val(GetMultisamplePNameNV pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexParameterIuiv_params(TextureParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetUniformBlockIndex_uniformBlockName()
        {
            throw new System.NotImplementedException();
        }

        public static int glTexParameteriv_params(TextureParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glBindFragDataLocation_name(string name)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetUniformuiv_params(uint program, int location)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetActiveUniformBlockiv_params(uint program, uint uniformBlockIndex, UniformBlockPName pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glTexSubImage3D_pixels(PixelFormat format, PixelType type, int width, int height, int depth)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetActiveUniformsiv_params(int uniformCount, UniformPName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glReadPixels_pixels(PixelFormat format, PixelType type, int width, int height)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexParameterfv_params(TextureParameterName pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetUniformdv_params(uint program, int location)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetDoublev_data(GetPName pname)
        {
            return glGetIntegerv_data(pname);
        }

        public static int glSamplerParameteriv_param(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexParameterIiv_params(TextureParameterName pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetIntegerv_data(GetPName pname)
        {
            // https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGet.xhtml
            switch (pname) {
                case GetPName.ACTIVE_TEXTURE:
                case GetPName.ARRAY_BUFFER_BINDING:
                case GetPName.BLEND:
                case GetPName.BLEND_DST_ALPHA:
                case GetPName.BLEND_DST_RGB:
                case GetPName.BLEND_EQUATION_RGB:
                case GetPName.BLEND_EQUATION_ALPHA:
                case GetPName.BLEND_SRC_ALPHA:
                case GetPName.BLEND_SRC_RGB:
                case GetPName.COLOR_LOGIC_OP:
                case GetPName.MAX_COMPUTE_SHADER_STORAGE_BLOCKS:
                case GetPName.MAX_COMBINED_SHADER_STORAGE_BLOCKS:
                case GetPName.MAX_COMPUTE_UNIFORM_BLOCKS:
                case GetPName.MAX_COMPUTE_TEXTURE_IMAGE_UNITS: 
                case GetPName.MAX_COMPUTE_UNIFORM_COMPONENTS:
                case GetPName.MAX_COMPUTE_ATOMIC_COUNTERS:
                case GetPName.MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS:
                case GetPName.MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS:
                case GetPName.MAX_COMPUTE_WORK_GROUP_INVOCATIONS:
                case GetPName.DISPATCH_INDIRECT_BUFFER_BINDING:
                case GetPName.MAX_DEBUG_GROUP_STACK_DEPTH:
                case GetPName.DEBUG_GROUP_STACK_DEPTH:
                case GetPName.CONTEXT_FLAGS:
                case GetPName.CULL_FACE:
                case GetPName.CULL_FACE_MODE:
                case GetPName.CURRENT_PROGRAM:
                
                case GetPName.MAJOR_VERSION:
                case GetPName.MINOR_VERSION:
                    
                case GetPName.TEXTURE_BINDING_1D:
                case GetPName.TEXTURE_BINDING_1D_ARRAY:
                case GetPName.TEXTURE_BINDING_2D:
                case GetPName.TEXTURE_BINDING_2D_ARRAY:
                case GetPName.TEXTURE_BINDING_2D_MULTISAMPLE:
                case GetPName.TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY:
                case GetPName.TEXTURE_BINDING_3D:
                case GetPName.TEXTURE_BINDING_BUFFER:
                case GetPName.TEXTURE_BINDING_CUBE_MAP:
                case GetPName.TEXTURE_BINDING_RECTANGLE:
                case GetPName.TEXTURE_COMPRESSION_HINT:
                case GetPName.TEXTURE_BUFFER_OFFSET_ALIGNMENT:
                case GetPName.TIMESTAMP:
                    
                case GetPName.VERTEX_ARRAY_BINDING:
                    
                case GetPName.SAMPLER_BINDING:
                    
                    return 1;
                
                case GetPName.ALIASED_LINE_WIDTH_RANGE:
                
                case GetPName.POLYGON_MODE:
                    
                    return 2;
                case GetPName.BLEND_COLOR:
                case GetPName.COLOR_CLEAR_VALUE:
                case GetPName.COLOR_WRITEMASK:
                    
                case GetPName.VIEWPORT:
                case GetPName.SCISSOR_BOX:
                    return 4;
                case GetPName.COMPRESSED_TEXTURE_FORMATS:
                    // Requires glGet of GL_NUM_COMPRESSED_TEXTURE_FORMATS
                    throw new System.NotImplementedException();
            }
            
            throw new System.NotImplementedException();
        }

        public static int glGetActiveSubroutineUniformiv_values(SubroutineParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetShaderiv_params(ShaderParameterName pname)
        {
            // https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetShader.xhtml
            switch (pname) {
                case ShaderParameterName.SHADER_TYPE:
                case ShaderParameterName.DELETE_STATUS:
                case ShaderParameterName.COMPILE_STATUS:
                case ShaderParameterName.INFO_LOG_LENGTH:
                case ShaderParameterName.SHADER_SOURCE_LENGTH:
                    return 1;
            }
            
            throw new System.NotImplementedException();
        }
        
        public static int glGetFramebufferAttachmentParameteriv_params(FramebufferAttachmentParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetInteger64i_v_data(uint target)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexImage3D_pixels(PixelFormat format, PixelType type, int width, int height, int depth)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetQueryIndexediv_params(QueryParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetBufferParameteriv_params(BufferPNameARB pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glPointParameteriv_params(PointParameterNameARB pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetQueryObjectiv_params(QueryObjectParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glVertexAttribPointer_pointer(int size, VertexAttribPointerType type, int stride)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawRangeElements_indices(int count, DrawElementsType type)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetIntegeri_v_data(uint target)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetTexParameterIuiv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetSamplerParameterIiv_params(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetSamplerParameteriv_params(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glMultiDrawArrays_first(int drawcount)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glMultiDrawArrays_count(int drawcount)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexImage2D_pixels(PixelFormat format, PixelType type, int width, int height)
        {
            // https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glTexImage2D.xhtml
            
            int components = format switch {
                PixelFormat.RED => 1,
                PixelFormat.RG => 2,
                PixelFormat.RGB => 3,
                PixelFormat.BGR => 3,
                PixelFormat.RGBA => 4,
                PixelFormat.BGRA => 4,
                PixelFormat.DEPTH_COMPONENT => 1,
                PixelFormat.DEPTH_STENCIL => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(format))
            };

            int componentSize = type switch {
                PixelType.UNSIGNED_BYTE => sizeof(byte),
                PixelType.BYTE => sizeof(byte),
                PixelType.UNSIGNED_SHORT => sizeof(ushort),
                PixelType.SHORT => sizeof(short),
                PixelType.UNSIGNED_INT => sizeof(uint),
                PixelType.INT => sizeof(int),
                // PixelType.HALF_FLOAT => ,  // TODO: Why didn't codegen generate this enumeration!? Looks like a 3+ feature.
                PixelType.FLOAT => sizeof(float),
                PixelType.UNSIGNED_BYTE_3_3_2 => sizeof(byte),
                //PixelType.UNSIGNED_BYTE_2_2_3_REV => ,
                //PixelType.UNSIGNED_SHORT_5_6_5 => , // CODE
                //PixelType.UNSIGNED_SHORT_5_6_5_REV => ,
                PixelType.UNSIGNED_SHORT_4_4_4_4 => sizeof(short),
                //PixelType.UNSIGNED_SHORT_4_4_4_4_REV => ,
                PixelType.UNSIGNED_SHORT_5_5_5_1 => sizeof(short),
                //PixelType.UNSIGNED_SHORT_1_5_5_5_REV => ,
                PixelType.UNSIGNED_INT_8_8_8_8 => sizeof(int),
                //PixelType.UNSIGNED_INT_8_8_8_8_REV => ,
                PixelType.UNSIGNED_INT_10_10_10_2 => sizeof(int),
                //PixelType.UNSIGNED_INT_2_10_10_10_REV => 
                _ => throw new ArgumentOutOfRangeException(nameof(type))
            };

            return components * componentSize * width * height;
        }

        public static int glGetTexLevelParameteriv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glSamplerParameterIuiv_param(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glPatchParameterfv_values(PatchParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetUniformiv_params(uint program, int location)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetTexParameteriv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetTexImage_pixels(TextureTarget target, int level, PixelFormat format, PixelType type)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetTexLevelParameterfv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetCompressedTexImage_img(TextureTarget target, int level)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawRangeElementsBaseVertex_indices(int count, DrawElementsType type)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetSamplerParameterfv_params(SamplerParameterF pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexImage1D_pixels(PixelFormat format, PixelType type, int width)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawElementsInstancedBaseVertex_indices(int count, DrawElementsType type)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetSamplerParameterIuiv_params(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetProgramiv_params(ProgramPropertyARB pname)
        {
            // https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/glGetProgram.xhtml
            switch (pname) {
                case ProgramPropertyARB.LINK_STATUS:
                case ProgramPropertyARB.INFO_LOG_LENGTH:
                    return 1;
            }
            throw new System.NotImplementedException();
        }

        public static int glGetBufferParameteri64v_params(BufferPNameARB pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glSamplerParameterfv_param(SamplerParameterF pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetTexParameterIiv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }
        
        public static int glGetBooleani_v_data(BufferTargetARB target)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetTexParameterfv_params(GetTextureParameter pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetQueryiv_params(QueryParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetFloatv_data(GetPName pname)
        {
            return glGetIntegerv_data(pname);
        }

        public static int glSamplerParameterIiv_param(SamplerParameterI pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetRenderbufferParameteriv_params(RenderbufferParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glClearBufferfv_value(Buffer buffer)
        {
            throw new System.NotImplementedException();
        }

        public static int glVertexAttribIPointer_pointer(int size, VertexAttribPointerType type, int stride)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetBooleanv_data(GetPName pname)
        {
            return glGetIntegerv_data(pname);
        }

        public static int glTexSubImage1D_pixels(PixelFormat format, PixelType type, int width)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetUniformfv_params(uint program, int location)
        {
            throw new System.NotImplementedException();
        }

        public static int glTexSubImage2D_pixels(PixelFormat format, PixelType type, int width, int height)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetQueryObjecti64v_params(QueryObjectParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetQueryObjectuiv_params(QueryObjectParameterName pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawElementsInstanced_indices(int count, DrawElementsType type)
        {
            throw new System.NotImplementedException();
        }

        public static int glClearBufferiv_value(Buffer buffer)
        {
            throw new System.NotImplementedException();
        }

        public static int glPointParameterfv_params(PointParameterNameARB pname)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawElements_indices(int count, DrawElementsType type)
        {
            throw new System.NotImplementedException();
        }

        public static int glGetFragDataLocation_name(string name)
        {
            throw new System.NotImplementedException();
        }

        public static int glDrawElementsBaseVertex_indices(int count, DrawElementsType type)
        {
            int indexSize = type switch {
                DrawElementsType.UNSIGNED_BYTE => sizeof(byte),
                DrawElementsType.UNSIGNED_SHORT => sizeof(short),
                DrawElementsType.UNSIGNED_INT => sizeof(int)
                , _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            return count * indexSize;
        }
    }
}