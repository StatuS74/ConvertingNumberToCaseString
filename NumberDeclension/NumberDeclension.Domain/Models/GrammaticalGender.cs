using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDeclension.Domain.Models
{
    public readonly struct GrammaticalGender
    {
        private GrammaticalGender(string code) => Code = code;
        public string Code { get; }
        public static readonly GrammaticalGender Masculine = new GrammaticalGender("М");
        public static readonly GrammaticalGender Feminine = new GrammaticalGender("Ж");
        public static readonly GrammaticalGender Neuter = new GrammaticalGender("С");
    }
}