using Ardalis.SmartEnum;

namespace MyHebrewBible.Client.Features.Hebrew.Enums;

public abstract class HebrewChart : SmartEnum<HebrewChart>
{
  #region  Declared Public Instances
  public static readonly HebrewChart Aleph = new AlephSE();
  public static readonly HebrewChart BetVet = new BetVetSE();
  public static readonly HebrewChart Gimel = new GimelSE();
  public static readonly HebrewChart Dalet = new DaletSE();
  public static readonly HebrewChart Hey = new HeySE();
  public static readonly HebrewChart Vav = new VavSE();
  public static readonly HebrewChart Zayin = new ZayinSE();
  public static readonly HebrewChart Chet = new ChetSE();
  public static readonly HebrewChart Tet = new TetSE();
  public static readonly HebrewChart Yood = new YoodSE();
  public static readonly HebrewChart Chaf = new ChafSE();
  public static readonly HebrewChart Lamed = new LamedSE();
  public static readonly HebrewChart Mem = new MemSE();
  public static readonly HebrewChart Nun = new NunSE();
  public static readonly HebrewChart Samech = new SamechSE();
  public static readonly HebrewChart Ayin = new AyinSE();
  public static readonly HebrewChart PeyFey = new PeyFeySE();
  public static readonly HebrewChart Tsadi = new TsadiSE();
  public static readonly HebrewChart Koof = new KoofSE();
  public static readonly HebrewChart Resh = new ReshSE();
  public static readonly HebrewChart SheenSeen = new SheenSeenSE();
  public static readonly HebrewChart Tav = new TavSE();
  #endregion

  private HebrewChart(string name, int value) : base(name, value) { } // Constructor

  #region Extra Fields
  public abstract int UniInt { get; }
  public abstract string? UnicodeName { get; }
  public abstract string? Hebrew { get; }
  public abstract string? EngLetter { get; }
  public abstract int Gematria { get; }
  public abstract int Strongs { get; }
  public abstract string? Sofit { get; }
  public abstract string? WithoutDagesh { get; }
  public abstract string? PrefixMeaning { get; }
  public abstract string? LiteralMeaning { get; }
  public abstract string? SymbolicMeaning { get; }
  public abstract int? Footnote { get; }  //string?

  /*
  public abstract int Id { get; }  
  public abstract string? UniHex { get; }
  public abstract int SortOrder { get; }
  public abstract int LetterCountUsage { get; }
  public abstract string? Link { get; }
  public abstract string? Comment { get; }

  public string LiteralAndSymbolicTwoLines
  {
    get { return LiteralMeaning + "<br />" + SymbolicMeaning; }
  }

  */
  #endregion

  #region Private Instantiation
  private sealed class AlephSE : HebrewChart
  {
    public AlephSE() : base("Aleph", 1) { }
    public override int UniInt => 1488;
    public override string UnicodeName => "Aleph";
    public override string Hebrew => "א";
    public override string EngLetter => "a";
    public override int Gematria => 1;
    public override string Sofit => "";
    public override int Strongs => 1;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "ox";
    public override string SymbolicMeaning => "strength, leadership, first";
    public override int? Footnote => null;
  }
  private sealed class BetVetSE : HebrewChart
  {
    public BetVetSE() : base("BetVet", 2) { }
    public override int UniInt => 1489;
    public override string UnicodeName => "BetVet";
    public override string Hebrew => "בּ";
    public override string EngLetter => "v";
    public override int Gematria => 2;
    public override string Sofit => "";
    public override int Strongs => 872;
    public override string WithoutDagesh => "ב";
    public override string PrefixMeaning => "in";
    public override string LiteralMeaning => "house, tent";
    public override string SymbolicMeaning => "household, in";
    public override int? Footnote => 1;
  }
  private sealed class GimelSE : HebrewChart
  {
    public GimelSE() : base("Gimel", 3) { }
    public override int UniInt => 1490;
    public override string UnicodeName => "Gimel";
    public override string Hebrew => "ג";
    public override string EngLetter => "g";
    public override int Gematria => 3;
    public override string Sofit => "";
    public override int Strongs => 1341;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "camel";
    public override string SymbolicMeaning => "pride, lift up, giver";
    public override int? Footnote => null;
  }
  private sealed class DaletSE : HebrewChart
  {
    public DaletSE() : base("Dalet", 4) { }
    public override int UniInt => 1491;
    public override string UnicodeName => "Dalet";
    public override string Hebrew => "ד";
    public override string EngLetter => "d";
    public override int Gematria => 4;
    public override string Sofit => "";
    public override int Strongs => 1668;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "door";
    public override string SymbolicMeaning => "pathway, enter";
    public override int? Footnote => null;
  }
  private sealed class HeySE : HebrewChart
  {
    public HeySE() : base("Hey", 5) { }
    public override int UniInt => 1492;
    public override string UnicodeName => "Hey";
    public override string Hebrew => "ה";
    public override string EngLetter => "h";
    public override int Gematria => 5;
    public override string Sofit => "";
    public override int Strongs => 1887;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "the";
    public override string LiteralMeaning => "window, fence";
    public override string SymbolicMeaning => "to reveal";
    public override int? Footnote => null;
  }
  private sealed class VavSE : HebrewChart
  {
    public VavSE() : base("Vav", 6) { }
    public override int UniInt => 1493;
    public override string UnicodeName => "Vav";
    public override string Hebrew => "ו";
    public override string EngLetter => "|"; // "\";
  
  public override int Gematria => 6;
    public override string Sofit => "";
    public override int Strongs => 2051;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "and, but";
    public override string LiteralMeaning => "nail";
    public override string SymbolicMeaning => "and, add, secure, hook";
    public override int? Footnote => null;
  }
  private sealed class ZayinSE : HebrewChart
  {
    public ZayinSE() : base("Zayin", 7) { }
    public override int UniInt => 1494;
    public override string UnicodeName => "Zayin";
    public override string Hebrew => "ז";
    public override string EngLetter => "z";
    public override int Gematria => 7;
    public override string Sofit => "";
    public override int Strongs => 2061;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "sword";
    public override string SymbolicMeaning => "cut, to cut off";
    public override int? Footnote => null;
  }
  private sealed class ChetSE : HebrewChart
  {
    public ChetSE() : base("Chet", 8) { }
    public override int UniInt => 1495;
    public override string UnicodeName => "Chet";
    public override string Hebrew => "ח";
    public override string EngLetter => "ch";
    public override int Gematria => 8;
    public override string Sofit => "";
    public override int Strongs => 2243;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "fence, hedge";
    public override string SymbolicMeaning => "private, to seperate";
    public override int? Footnote => null;
  }
  private sealed class TetSE : HebrewChart
  {
    public TetSE() : base("Tet", 9) { }
    public override int UniInt => 1496;
    public override string UnicodeName => "Tet";
    public override string Hebrew => "ט";
    public override string EngLetter => "t";
    public override int Gematria => 9;
    public override string Sofit => "";
    public override int Strongs => 2868;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "to surround";
    public override string SymbolicMeaning => "snake, twist";
    public override int? Footnote => null;
  }
  private sealed class YoodSE : HebrewChart
  {
    public YoodSE() : base("Yood", 10) { }
    public override int UniInt => 1497;
    public override string UnicodeName => "Yood";
    public override string Hebrew => "י";
    public override string EngLetter => "y";
    public override int Gematria => 10;
    public override string Sofit => "";
    public override int Strongs => 2968;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "closed hand";
    public override string SymbolicMeaning => "dead, work, to make";
    public override int? Footnote => null;
  }
  private sealed class ChafSE : HebrewChart
  {
    public ChafSE() : base("Chaf", 11) { }
    public override int UniInt => 1499;
    public override string UnicodeName => "Chaf";
    public override string Hebrew => "כּ";
    public override string EngLetter => "c";
    public override int Gematria => 20;
    public override string Sofit => "ך";
    public override int Strongs => 3510;
    public override string WithoutDagesh => "כ";
    public override string PrefixMeaning => "as, like";
    public override string LiteralMeaning => "arm, open hand";
    public override string SymbolicMeaning => "to cover, allow, strength";
    public override int? Footnote => null;
  }
  private sealed class LamedSE : HebrewChart
  {
    public LamedSE() : base("Lamed", 12) { }
    public override int UniInt => 1500;
    public override string UnicodeName => "Lamed";
    public override string Hebrew => "ל";
    public override string EngLetter => "l";
    public override int Gematria => 30;
    public override string Sofit => "";
    public override int Strongs => 3808;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "to, for";
    public override string LiteralMeaning => "staff, cattle goad";
    public override string SymbolicMeaning => "prod, go toward";
    public override int? Footnote => null;
  }
  private sealed class MemSE : HebrewChart
  {
    public MemSE() : base("Mem", 13) { }
    public override int UniInt => 1502;
    public override string UnicodeName => "Mem";
    public override string Hebrew => "מ";
    public override string EngLetter => "m";
    public override int Gematria => 40;
    public override string Sofit => "ם";
    public override int Strongs => 3964;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "from";
    public override string LiteralMeaning => "water";
    public override string SymbolicMeaning => "massive, overpower, chaos";
    public override int? Footnote => null;
  }
  private sealed class NunSE : HebrewChart
  {
    public NunSE() : base("Nun", 14) { }
    public override int UniInt => 1504;
    public override string UnicodeName => "Nun";
    public override string Hebrew => "נ";
    public override string EngLetter => "n";
    public override int Gematria => 50;
    public override string Sofit => "ן";
    public override int Strongs => 4994;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "fish (moving)";
    public override string SymbolicMeaning => "activity, life";
    public override int? Footnote => null;
  }
  private sealed class SamechSE : HebrewChart
  {
    public SamechSE() : base("Samech", 15) { }
    public override int UniInt => 1505;
    public override string UnicodeName => "Samech";
    public override string Hebrew => "ס";
    public override string EngLetter => "sa";
    public override int Gematria => 60;
    public override string Sofit => "";
    public override int Strongs => 5429;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "a prop";
    public override string SymbolicMeaning => "support, turn";
    public override int? Footnote => null;
  }
  private sealed class AyinSE : HebrewChart
  {
    public AyinSE() : base("Ayin", 16) { }
    public override int UniInt => 1506;
    public override string UnicodeName => "Ayin";
    public override string Hebrew => "ע";
    public override string EngLetter => "i";
    public override int Gematria => 70;
    public override string Sofit => "";
    public override int Strongs => 5645;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "eye";
    public override string SymbolicMeaning => "see, know, experience";
    public override int? Footnote => null;
  }
  private sealed class PeyFeySE : HebrewChart
  {
    public PeyFeySE() : base("PeyFey", 17) { }
    public override int UniInt => 1508;
    public override string UnicodeName => "PeyFey";
    public override string Hebrew => "פּ";
    public override string EngLetter => "f";
    public override int Gematria => 80;
    public override string Sofit => "ף";
    public override int Strongs => 6284;
    public override string WithoutDagesh => "פ";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "mouth";
    public override string SymbolicMeaning => "speak, open, word";
    public override int? Footnote => 2;
  }
  private sealed class TsadiSE : HebrewChart
  {
    public TsadiSE() : base("Tsadi", 18) { }
    public override int UniInt => 1510;
    public override string UnicodeName => "Tsadi";
    public override string Hebrew => "צ";
    public override string EngLetter => "ts";
    public override int Gematria => 90;
    public override string Sofit => "ץ";
    public override int Strongs => 6627;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "fish hook";
    public override string SymbolicMeaning => "harvest, desire";
    public override int? Footnote => null;
  }
  private sealed class KoofSE : HebrewChart
  {
    public KoofSE() : base("Koof", 19) { }
    public override int UniInt => 1511;
    public override string UnicodeName => "Koof";
    public override string Hebrew => "ק";
    public override string EngLetter => "k";
    public override int Gematria => 100;
    public override string Sofit => "";
    public override int Strongs => 6892;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "back of head";
    public override string SymbolicMeaning => "behind, last, least";
    public override int? Footnote => null;
  }
  private sealed class ReshSE : HebrewChart
  {
    public ReshSE() : base("Resh", 20) { }
    public override int UniInt => 1512;
    public override string UnicodeName => "Resh";
    public override string Hebrew => "ר";
    public override string EngLetter => "r";
    public override int Gematria => 200;
    public override string Sofit => "";
    public override int Strongs => 7200;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "head";
    public override string SymbolicMeaning => "person, head, highest";
    public override int? Footnote => null;
  }
  private sealed class SheenSeenSE : HebrewChart
  {
    public SheenSeenSE() : base("SheenSeen", 21) { }
    public override int UniInt => 1513;
    public override string UnicodeName => "SheenSeen";
    public override string Hebrew => "שׁ";
    public override string EngLetter => "s";
    public override int Gematria => 300;
    public override string Sofit => "";
    public override int Strongs => 7579;
    public override string WithoutDagesh => "שׂ";
    public override string PrefixMeaning => "that";
    public override string LiteralMeaning => "teeth";
    public override string SymbolicMeaning => "consume, destroy";
    public override int? Footnote => 3;
  }
  private sealed class TavSE : HebrewChart
  {
    public TavSE() : base("Tav", 22) { }
    public override int UniInt => 1514;
    public override string UnicodeName => "Tav";
    public override string Hebrew => "ת";
    public override string EngLetter => "th";
    public override int Gematria => 400;
    public override string Sofit => "";
    public override int Strongs => 8372;
    public override string WithoutDagesh => "";
    public override string PrefixMeaning => "";
    public override string LiteralMeaning => "sign, cross";
    public override string SymbolicMeaning => "covenant, seal";
    public override int? Footnote => null;
  }
  #endregion
}
