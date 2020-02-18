using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern
{
    public abstract class President
    {
        public abstract string Slogan { get;}
    }

    class PresidentLREM : President
    {
        public override string Slogan { get => "Slogan pourri numéro 1"; }
    }

    class PresidentDuCentre : President
    {
        public override string Slogan { get => "Slogan pourri numéro 2"; }
    }

    class PresidentExtremeGauche : President
    {
        public override string Slogan { get => "Slogan pourri numéro 3"; }
    }

    class PresidentEcologiste : President
    {
        public override string Slogan { get => "Slogan pourri numéro 4"; }
    }

    class PresidentDeGauche : President
    {
        public override string Slogan { get => "Slogan pourri numéro 5"; }
    }

    class PresidentDeDroite : President
    {
        public override string Slogan { get => "Slogan pourri numéro 6"; }
    }

    class PresidentExtremeDroite : President
    {
        public override string Slogan { get => "Slogan pourri numéro 7"; }
    }

}
