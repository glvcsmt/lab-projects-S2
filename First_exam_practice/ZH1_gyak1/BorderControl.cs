using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_gyak1
{
    public class BorderControl
    {
        IDocument[] tomb;
        int dokumentumSzam;

        public int DokumentumSzam { get => dokumentumSzam; }

        public BorderControl(IDocument[] tombElemszam)
        {
            this.tomb = tombElemszam;
            this.dokumentumSzam = 0;
        }

        void AddDocument(IDocument doc)
        {
            int idx = 0;
            while (idx < tomb.Length && tomb[idx] != null) idx++;
            if(idx == tomb.Length) throw new DossierFullException(this);
            tomb[++idx] = doc;
        }

        public bool CheckValidity()
        {
            int utlevelIndex = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] is Passport)
                {
                    utlevelIndex = i;
                    if (tomb[i].isNotExpired(DateTime.Today) == false) throw new ExpiredPassportException(tomb[i]);
                    break;
                }
            }       
            if (utlevelIndex == -1) throw new MissingPassportException();

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].Name != tomb[utlevelIndex].Name) throw new NameErrorException(tomb[i]);
                if (tomb[i].PassportNumber != tomb[utlevelIndex].PassportNumber) throw new PassportNumberErrorException(tomb[i]);
                if (tomb[i].isNotExpired(DateTime.Today) == false) throw new InvalidDocumentException(tomb[i]);
            }
            return true;
        } 
    }
}
