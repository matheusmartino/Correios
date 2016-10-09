using System.Diagnostics;

namespace CorreiosBusiness
{
    public class Business
    {
        public void CodigoComComplexidadeSintomaticaAlta(string s)
        {
            if (string.IsNullOrEmpty(s)) return;

            if (s.Length != 11 || s.Contains(".")) return;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'A':
                        Trace.TraceWarning("ALM");
                        break;

                    case 'B':
                        Trace.TraceWarning("BUILD");
                        break;

                    case 'C':
                        Trace.TraceWarning("CODE");
                        break;

                    case 'D':
                        Trace.TraceWarning("DEVOPS");
                        break;

                    case 'E':
                        Trace.TraceWarning("ENTERPROISE");
                        break;

                    default:
                        Trace.TraceWarning("DEFAULT");
                        break;
                }
            }
        }
    }
}
