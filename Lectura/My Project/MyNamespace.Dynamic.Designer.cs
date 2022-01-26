using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Lectura.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Lectura m_Lectura;

            public Lectura Lectura
            {
                [DebuggerHidden]
                get
                {
                    m_Lectura = Create__Instance__(m_Lectura);
                    return m_Lectura;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Lectura))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Lectura);
                }
            }
        }
    }
}