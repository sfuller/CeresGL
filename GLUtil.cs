using System;
using System.Text;

namespace CeresGL
{
    public static class GLUtil
    {
        public static string GetShaderInfoLog(GL gl, uint shader)
        {
            Span<int> outputs = stackalloc int[1];
            gl.GetShaderiv(shader, ShaderParameterName.INFO_LOG_LENGTH, outputs);
            int infoLogLength = outputs[0];
            byte[] infoLogBytes = new byte[infoLogLength];
            gl.GetShaderInfoLog(shader, infoLogLength, stackalloc int[1], infoLogBytes);
            return Encoding.ASCII.GetString(infoLogBytes);
        }

        public static string GetProgramInfoLog(GL gl, uint program)
        {
            Span<int> outputs = stackalloc int[1];
            gl.GetProgramiv(program, ProgramPropertyARB.INFO_LOG_LENGTH, outputs);
            int infoLogLength = outputs[0];
            byte[] infoLogBytes = new byte[infoLogLength];
            gl.GetProgramInfoLog(program, infoLogLength, stackalloc int[1], infoLogBytes);
            return Encoding.ASCII.GetString(infoLogBytes);
        }
    }
}
