using Core.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Files
{
    public class File:ModelEntity
    {
        public string FileName { get; set; }   
        public string Path { get; set; }    
        public bool ShowCase { get; set; }  
        
    }
}
