using System.Collections.Generic;

namespace ResourceStringsTranslate
{
    public class FormMainData
    {
        public List<string> Status { get; } = new List<string>();

        public int Progress { get; set; }

        public List<FormMainDataResourceFile> ResourceFiles { get; set; } = new List<FormMainDataResourceFile>();
    }
}
