using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Document
    {
        public void OpenDocument() { Console.WriteLine("Document Opened"); }
        public virtual void EditDocument() { Console.WriteLine("Can Edit in Pro and Expert versions"); }
        public virtual void SaveDocument() { Console.WriteLine("Can Save in Pro and Expert versions"); }
    }

    class ProDocument : Document
    {
        public new void OpenDocument() { Console.WriteLine("Pro Document Opened"); }
        public sealed override void EditDocument() { Console.WriteLine("Pro Document edited"); }
        public new void SaveDocument() { Console.WriteLine("Pro Document Saved in doc format, for pdf format buy Expert packet"); }
    }

    class ExpertDocument : ProDocument
    {
        public new void OpenDocument() { Console.WriteLine("Expert Document Opened"); }
        public new void EditDocument() { Console.WriteLine("Expert Document edited"); }
        public new void SaveDocument() { Console.WriteLine("Expert Document Saved in doc format, for pdf format buy Expert packet"); }
    }

    class Controller
    {
        private string command;
        public void Suggestion()
        {
            Console.WriteLine(
                "basic = DocumentProgram"+
                "pro = ProDocumentProgam"+
                "exppert = ExpertDocumentProgram"
                );
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
