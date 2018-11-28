using System;
using System.Collections.Generic;
using System.Text;

namespace Homework06.lib
{
    public class Homework06Lib : IHomework06
    {
        public List<string> listLED { get; set; }
        public List<string> listNoLED { get; set; }
        public List<string> listState { get; set; }
        public List<string> config { get; set; }
        public void setLED()
        {
            listLED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            listNoLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            listState = new List<string>(new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" });
            config = new List<string>(new string[] { });
        }
        public string DisplayLEDOnScreen(string ledNo)
        {
            ledNo = ledNo.ToUpper();
            var disPlayLED = new StringBuilder();

            for (int i = 0; i < listNoLED.Count; i++)
            {

            }
            for (int i = 0; i < listNoLED.Count; i++)
            {
                if (ledNo == listNoLED[i])
                {
                    listLED[i] = (listLED[i] == "[ ]") ? "[i]" : "[ ]";
                }
            }
            var LED = String.Join(" ", listLED);
            var noLED = String.Join("   ", listNoLED);
            var result = disPlayLED.Append(LED).AppendLine().Append(" ").Append(noLED).ToString();

            return result;
        }

        public string LoadState()
        {
            throw new NotImplementedException();
        }

        public void SaveCurrentState()
        {
            throw new NotImplementedException();
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            throw new NotImplementedException();
        }
    }
}
