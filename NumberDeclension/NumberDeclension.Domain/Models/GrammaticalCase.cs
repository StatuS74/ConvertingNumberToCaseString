using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDeclension.Domain.Models
{
    public readonly struct GrammaticalCase
    {
        private GrammaticalCase(string code) => Code = code;
        public string Code { get; }
        public static readonly GrammaticalCase Nominative = new GrammaticalCase("И");
        public static readonly GrammaticalCase Genitive = new GrammaticalCase("Р");
        public static readonly GrammaticalCase Dative = new GrammaticalCase("Д");
        public static readonly GrammaticalCase Accusative = new GrammaticalCase("В");
        public static readonly GrammaticalCase Instrumental = new GrammaticalCase("Т");
        public static readonly GrammaticalCase Prepositional = new GrammaticalCase("П");
    }

}
