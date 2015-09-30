using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wroxx.Publishing.Infrastructure;

namespace Wroxx.Publishing.Tests
{
    public class MockBookManager:IBook
    {
        public string ISBN
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Content { get; set; }

        public string GetContents()
        {

            return Content;

        }
    }
}
