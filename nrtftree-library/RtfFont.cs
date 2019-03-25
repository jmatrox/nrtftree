using System;
using System.Collections.Generic;
using System.Text;

using Net.Sgoliver.NRtfTree.Core;

namespace Net.Sgoliver.NRtfTree
{
    namespace Util
    {
        public enum RtfFontFamilies
        {
            Nil = 0,
            Roman = 1,
            Swiss = 2,
            Modern = 3,
            Script = 4,
            Decor = 5,
            Tech = 6,
            Bidi = 7
        }

        public class RtfFont
        {
            #region Members

            private int index;
            private string name = "";
            private RtfFontFamilies family = RtfFontFamilies.Nil;
            private int charset = -1;
            private int prq = -1;
            private RtfNodeCollection formatting = null;

            #endregion

            #region Properties

            public int Index { get => index; set => index = value; }
            public string Name { get => name; set => name = value; }
            public RtfFontFamilies Family { get => family; set => family = value; }
            public int Charset { get => charset; set => charset = value; }
            public int Prq { get => prq; set => prq = value; }
            public RtfNodeCollection Formatting { get => formatting; set => formatting = value; }

            #endregion

            public RtfFont()
            {
                formatting = new RtfNodeCollection();
            }

            public override string ToString()
            {
                string res = string.Empty;

                res += $"\\f{Index}";

                switch (family)
                {
                    case RtfFontFamilies.Nil: res += "\\fnil"; break;
                    case RtfFontFamilies.Roman: res += "\\froman"; break;
                    case RtfFontFamilies.Swiss: res += "\\fswiss"; break;
                    case RtfFontFamilies.Modern: res += "\\fmodern"; break;
                    case RtfFontFamilies.Script: res += "\\fscript"; break;
                    case RtfFontFamilies.Decor: res += "\\fdecor"; break;
                    case RtfFontFamilies.Tech: res += "\\ftech"; break;
                    case RtfFontFamilies.Bidi: res += "\\fbidi"; break;
                }

                if (Charset >= 0) res += $"\\fcharset{Charset}";
                if (Prq >= 0) res += $"\\fprq{Prq}";

                for (int i = 0; i < formatting.Count; i++)
                    res += formatting[i].Rtf;

                res += $" {Name};";

                return res;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj is RtfFont font)
                {
                    string fontFormatting = string.Empty;
                    for (int i = 0; i < font.formatting.Count; i++)
                        fontFormatting += font.formatting[i].Rtf;

                    string thisFormatting = string.Empty;
                    for (int i = 0; i < formatting.Count; i++)
                        thisFormatting += formatting[i].Rtf;

                    return font.name == this.name
                        && font.family == this.family
                        && font.charset == this.charset
                        && font.prq == this.prq
                        && fontFormatting == thisFormatting;
                }      

                return false;
            }
        }
    }
}
