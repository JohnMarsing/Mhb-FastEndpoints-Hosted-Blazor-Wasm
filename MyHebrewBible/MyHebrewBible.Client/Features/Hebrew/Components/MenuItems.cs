using Ardalis.SmartEnum;

using PageLink = MyHebrewBible.Client.Enums.Nav;

namespace MyHebrewBible.Client.Features.Hebrew.Components;

public abstract class MenuItems : SmartEnum<MenuItems>
{

    #region Id's
    private static class Id
    {
        internal const int Chart = 1; // Hebrew "Home" Page
        internal const int Print = 2;
        internal const int Zepc3v8 = 3;
        internal const int Definitions = 4;
        internal const int Unicode = 5;
        internal const int QereKetiv = 6;
        internal const int Peshitta = 7;
    }
    #endregion

    #region  Declared Public Instances
    public static readonly MenuItems Chart = new ChartSE();
    public static readonly MenuItems Print = new PrintSE();
    public static readonly MenuItems Zepc3v8 = new Zepc3v8SE();
    public static readonly MenuItems Definitions = new DefinitionsSE();
    public static readonly MenuItems Unicode = new UnicodeSE();
    public static readonly MenuItems QereKetiv = new QereKetivSE();
    public static readonly MenuItems Peshitta = new PeshittaSE();
    // SE=SmartEnum
    #endregion

    private MenuItems(string name, int value) : base(name, value) { } // Constructor

    #region Extra Fields
    public abstract string Icon { get; }
    public abstract string Title { get; }
    public abstract string Page { get; }
    #endregion

    #region Private Instantiation

    private sealed class ChartSE : MenuItems
    {
        public ChartSE() : base($"{nameof(Id.Chart)}", Id.Chart) { }
        public override string Icon => "fa fa-table";
        public override string Title => nameof(Id.Chart);
        public override string Page => PageLink.Hebrew.Index;  //"Hebrew"
    }

    private sealed class PrintSE : MenuItems
    {
        public PrintSE() : base($"{nameof(Id.Print)}", Id.Print) { }
        public override string Icon => "fa fa-print";
        public override string Title => nameof(Id.Print);
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.Print); // /Hebrew/Print
    }

    private sealed class Zepc3v8SE : MenuItems
    {
        public Zepc3v8SE() : base($"{nameof(Id.Zepc3v8)}", Id.Zepc3v8) { }
        public override string Icon => "fa fa-plane";
        public override string Title => "Zep 3:8";
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.Zepc3v8); // /Hebrew/Zepc3v8
    }

    private sealed class DefinitionsSE : MenuItems
    {
        public DefinitionsSE() : base($"{nameof(Id.Definitions)}", Id.Definitions) { }
        public override string Icon => "fab fa-wordpress";
        public override string Title => nameof(Id.Definitions);
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.Definitions); // /Hebrew/Definitions
    }

    private sealed class UnicodeSE : MenuItems
    {
        public UnicodeSE() : base($"{nameof(Id.Unicode)}", Id.Unicode) { }
        public override string Icon => "fa fa-underline";
        public override string Title => nameof(Id.Unicode);
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.Unicode); // /Hebrew/Unicode
    }

    private sealed class QereKetivSE : MenuItems
    {
        public QereKetivSE() : base($"{nameof(Id.QereKetiv)}", Id.QereKetiv) { }
        public override string Icon => "fas fa-list";
        public override string Title => nameof(Id.QereKetiv);
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.QereKetiv); // /Hebrew/QereKetiv
    }

    private sealed class PeshittaSE : MenuItems
    {
        public PeshittaSE() : base($"{nameof(Id.Peshitta)}", Id.Peshitta) { }
        public override string Icon => "fas fa-ruble-sign"; // fa-pinterest-p, fa-product-hunt  
        public override string Title => nameof(Id.Peshitta);
        public override string Page => PageLink.Hebrew.Index + "/" + nameof(Id.Peshitta); // /Hebrew/Peshitta
    }

    #endregion
}

//public static readonly Windmill Audit = new AuditSE();


/*
public override string Color => "dark";
public override string Page => PageLink.Audit.Page;
public override string Title => PageLink.Audit.Title;
*/