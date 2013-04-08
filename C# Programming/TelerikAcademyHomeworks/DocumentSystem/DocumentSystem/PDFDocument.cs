using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class PDFDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted;

        public int NumberOfPages
        {
            get;
            protected set;
        }

        public bool IsEncrypted
        {
            get { return this.isEncrypted; }
        }

        public void Encrypt()
        {
            this.isEncrypted = true;
        }

        public void Decrypt()
        {
            this.isEncrypted = false;
        }
    }
}
