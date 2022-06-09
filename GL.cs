using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CeresGL
{
    public partial class GL
    {
        //
        // Hand-coded implementations of non-generate-able wrapper functions are defined here.
        //

        public void ShaderSource(uint shader, string source)
        {
            IntPtr sourcePtr = Marshal.StringToHGlobalAnsi(source);
            try {
                ShaderSource(shader, Encoding.ASCII.GetBytes(source));
            }
            finally {
                Marshal.FreeHGlobal(sourcePtr);
            }
        }

        public unsafe void ShaderSource(uint shader, byte[] source)
        {
            fixed (byte* bytePtr = source) {
                Span<IntPtr> strings = stackalloc [] { (IntPtr)bytePtr };
                Span<int> lengths = stackalloc [] {source.Length};
                fixed (IntPtr* stringsPtr = strings)
                fixed (int* lengthsPtr = lengths) {
                    glShaderSource(shader, 1, (IntPtr)stringsPtr, (IntPtr)lengthsPtr);
                }
            }
        }

        /// <summary>
        /// BufferData with no copy, and therefore no data parameter. Underlying command is called with null pointer to
        /// data parameter.
        /// </summary>
        public void BufferData(BufferTargetARB target, uint size, BufferUsageARB usage)
        {
            glBufferData((uint) target, (IntPtr) size, IntPtr.Zero, (uint) usage);
        }

        public unsafe void BufferData<T>(BufferTargetARB target, Span<T> data, BufferUsageARB usage) where T : unmanaged
        {
            fixed (void* dataPtr = data) { 
                glBufferData((uint) target, (IntPtr)(data.Length * sizeof(T)), (IntPtr)dataPtr, (uint)usage);    
            }
        }

        public unsafe void BufferData<T>(BufferTargetARB target, uint count, BufferUsageARB usage) where T : unmanaged
        {
            BufferData(target, count * (uint)sizeof(T), usage);
        }

        public unsafe void BufferSubData<T>(BufferTargetARB target, ulong offset, Span<T> data) where T : unmanaged
        {
            fixed (void* dataPtr = data) {
                uint elementSize = (uint)Marshal.SizeOf<T>();
                glBufferSubData((uint)target, (IntPtr)(offset * elementSize), (IntPtr)(data.Length * elementSize), (IntPtr)dataPtr);
            }
        }

        public void TexImage2DPixelBuffer(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, uint pboOffset)
        {
            glTexImage2D((uint) target, level, (int)internalFormat, width, height, border, (uint) format, (uint) type, (IntPtr) pboOffset);
        }

        public void DrawElements(PrimitiveType mode, int count, DrawElementsType type, uint firstElement)
        {
            IntPtr offset;
            switch (type) {
                case DrawElementsType.UNSIGNED_BYTE:
                    offset = (IntPtr)(firstElement * sizeof(byte));
                    break;
                case DrawElementsType.UNSIGNED_SHORT:
                    offset = (IntPtr) (firstElement * sizeof(ushort));
                    break;
                case DrawElementsType.UNSIGNED_INT:
                    offset = (IntPtr) (firstElement * sizeof(uint));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
            glDrawElements((uint) mode, count, (uint) type, offset);
        }
    }
}
