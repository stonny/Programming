using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class OfficeDocuments : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted
        {
            get { throw new NotImplementedException(); }
        }

        public int Version
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Encrypt()
        {
            throw new NotImplementedException();
        }

        public void Decrypt()
        {
            throw new NotImplementedException();
        }
    }
}
