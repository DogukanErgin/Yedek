using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            textBox1.Text = "lütfen metin giriniz";
            
         

        }
        public string RomajiConverter()
        {
            var metin = textBox1.Text;
            var yenimetin = "";
            yenimetin = metin.Replace("ー", "ー");
            yenimetin = yenimetin.Replace("時", "time"); //radikal 日
            yenimetin = yenimetin.Replace("詩", "poem");//言
            yenimetin = yenimetin.Replace("持", "hold");//扌
            yenimetin = yenimetin.Replace("⼈", "ひと");
            yenimetin = yenimetin.Replace("⺅", "にんべん");
            yenimetin = yenimetin.Replace("𠆢", "ひとやね");
            yenimetin = yenimetin.Replace("⼉", "ひとあし");
            yenimetin = yenimetin.Replace("⼊", "いる");
            yenimetin = yenimetin.Replace("⼋", "はち");
            yenimetin = yenimetin.Replace("⼌", "けいがまえ");
            yenimetin = yenimetin.Replace("⼍", "わかんむり");
            yenimetin = yenimetin.Replace("⼎", "にすい");
            yenimetin = yenimetin.Replace("⼏", "きにょう");
            yenimetin = yenimetin.Replace("⺇", "かぜかんむり");
            yenimetin = yenimetin.Replace("⼐", "かんにょう");
            yenimetin = yenimetin.Replace("⼑", "かたな");
            yenimetin = yenimetin.Replace("⺉", "りっとう");
            yenimetin = yenimetin.Replace("⼒", "ちから");
            yenimetin = yenimetin.Replace("⼓", "つつみがまえ");
            yenimetin = yenimetin.Replace("⼔", "さじ");
            yenimetin = yenimetin.Replace("⼕", "はこがまえ");
            yenimetin = yenimetin.Replace("⼖", "かくしがまえ");
            yenimetin = yenimetin.Replace("⼗", "じゅう");
            yenimetin = yenimetin.Replace("⼘", "ぼく");
            yenimetin = yenimetin.Replace("⼙", "ふしづくり");
            yenimetin = yenimetin.Replace("⼚", "がんだれ");
            yenimetin = yenimetin.Replace("⼛", "む");
            yenimetin = yenimetin.Replace("⼜", "また");
            yenimetin = yenimetin.Replace("⼝", "くち");
            yenimetin = yenimetin.Replace("⼞", "くにがまえ");
            yenimetin = yenimetin.Replace("⼟", "つち");
            yenimetin = yenimetin.Replace("⼠", "さむらい");
            yenimetin = yenimetin.Replace("⼡", "のまた");
            yenimetin = yenimetin.Replace("⼢", "なつあし");
            yenimetin = yenimetin.Replace("⼣", "ゆうべ");
            yenimetin = yenimetin.Replace("⼤", "だい");
            yenimetin = yenimetin.Replace("⼥", "おんな");
            yenimetin = yenimetin.Replace("⼦", "こ");
            yenimetin = yenimetin.Replace("⼧", "うかんむり");
            yenimetin = yenimetin.Replace("⼨", "すん");
            yenimetin = yenimetin.Replace("⼩", "しょう");
            yenimetin = yenimetin.Replace("⺌", "しょうかんむり");
            yenimetin = yenimetin.Replace("⺐", "だいのまげあし");
            yenimetin = yenimetin.Replace("⼫", "しかばね");
            yenimetin = yenimetin.Replace("⼬", "くさのめ");
            yenimetin = yenimetin.Replace("⼭", "やま");
            yenimetin = yenimetin.Replace("⼮", "まがりがわ");
            yenimetin = yenimetin.Replace("川", "さんぼんがわ");
            yenimetin = yenimetin.Replace("⼯", "たくみ");
            yenimetin = yenimetin.Replace("⼰", "おのれ");
            yenimetin = yenimetin.Replace("⼱", "はば");
            yenimetin = yenimetin.Replace("⼲", "かん");
            yenimetin = yenimetin.Replace("⺓", "いとがしら");
            yenimetin = yenimetin.Replace("⼴", "まだれ");
            yenimetin = yenimetin.Replace("⼵", "えんにょう");
            yenimetin = yenimetin.Replace("⼶", "にじゅうあし");
            yenimetin = yenimetin.Replace("⼷", "いぐるみ");
            yenimetin = yenimetin.Replace("⼸", "ゆみ");
            yenimetin = yenimetin.Replace("⼹", "けいがしら");
            yenimetin = yenimetin.Replace("⺕", "けいがしら");
            yenimetin = yenimetin.Replace("⺔", "けいがしら");
            yenimetin = yenimetin.Replace("⼺", "さんづくり");
            yenimetin = yenimetin.Replace("⼻", "ぎょうにんべん");
            yenimetin = yenimetin.Replace("⺾", "くさかんむり");
            yenimetin = yenimetin.Replace("⻌", "しんにょう");
            yenimetin = yenimetin.Replace("⻏", "おおざと");
            yenimetin = yenimetin.Replace("⻖", "こざとへん");
            yenimetin = yenimetin.Replace("⺍", "つ");
            yenimetin = yenimetin.Replace("⺖", "りっしんべん");
            yenimetin = yenimetin.Replace("⺘", "てへん");
            yenimetin = yenimetin.Replace("⺡", "さんずい");
            yenimetin = yenimetin.Replace("⺨", "けものへん");
            yenimetin = yenimetin.Replace("⼼", "こころ");
            yenimetin = yenimetin.Replace("⺗", "したごころ");
            yenimetin = yenimetin.Replace("⼽", "ほこ");
            yenimetin = yenimetin.Replace("⼾", "と");
            yenimetin = yenimetin.Replace("⼿", "て");
            yenimetin = yenimetin.Replace("⽀", "しにょう");
            yenimetin = yenimetin.Replace("⽁", "ぼくづくり");
            yenimetin = yenimetin.Replace("⺙", "ぼくづくり");
            yenimetin = yenimetin.Replace("⽂", "ぶん");
            yenimetin = yenimetin.Replace("⽃", "ますづくり");
            yenimetin = yenimetin.Replace("⽄", "おのづくり");
            yenimetin = yenimetin.Replace("⽅", "ほう");
            yenimetin = yenimetin.Replace("⽆", "むにょう");
            yenimetin = yenimetin.Replace("⽇", "ひ");
            yenimetin = yenimetin.Replace("⽈", "ひらび");
            yenimetin = yenimetin.Replace("⽉", "つき");
            yenimetin = yenimetin.Replace("⺝", "つきへん");
            yenimetin = yenimetin.Replace("⽊", "き");
            yenimetin = yenimetin.Replace("⽋", "あくび");
            yenimetin = yenimetin.Replace("⽌", "とめる");
            yenimetin = yenimetin.Replace("⽍", "がつ");
            yenimetin = yenimetin.Replace("⽎", "るまた");   
            yenimetin = yenimetin.Replace("⽏", "なかれ");
            yenimetin = yenimetin.Replace("⽐", "くらべる");
            yenimetin = yenimetin.Replace("⽑", "け");
            yenimetin = yenimetin.Replace("⽒", "うじ");
            yenimetin = yenimetin.Replace("⽓", "きがまえ");
            yenimetin = yenimetin.Replace("⽔", "みず");
            yenimetin = yenimetin.Replace("⽕", "ひ");
            yenimetin = yenimetin.Replace("⺣", "れっか");
            yenimetin = yenimetin.Replace("⽖", "つめ");
            yenimetin = yenimetin.Replace("⺤", "つめかんむり");
            yenimetin = yenimetin.Replace("爫", "つめかんむり");
            yenimetin = yenimetin.Replace("⽗", "ちち");
            yenimetin = yenimetin.Replace("⽘", "こう");
            yenimetin = yenimetin.Replace("⽙", "しょうへん");
            yenimetin = yenimetin.Replace("⽚", "かた");
            yenimetin = yenimetin.Replace("⽜", "うし");
            yenimetin = yenimetin.Replace("⽝", "いぬ");
            yenimetin = yenimetin.Replace("⺭", "しめすへん");
            yenimetin = yenimetin.Replace("㓁", "あみがしら");
            yenimetin = yenimetin.Replace("⺹", "おいかんむり");
            yenimetin = yenimetin.Replace("⽞", "げん");
            yenimetin = yenimetin.Replace("⽟", "たま");
            yenimetin = yenimetin.Replace("⽡", "かわら");
            yenimetin = yenimetin.Replace("⽢", "あまい");
            yenimetin = yenimetin.Replace("⽣", "うまれる");
            yenimetin = yenimetin.Replace("⽤", "もちいる");
            yenimetin = yenimetin.Replace("⽥", "た");
            yenimetin = yenimetin.Replace("⽦", "ひき");
            yenimetin = yenimetin.Replace("⽦", "ひき");
            yenimetin = yenimetin.Replace("⺪", "ひきへん");
            yenimetin = yenimetin.Replace("⽧", "やまいだれ");
            yenimetin = yenimetin.Replace("⽨", "はつがしら");
            yenimetin = yenimetin.Replace("⽩", "しろ");
            yenimetin = yenimetin.Replace("⽪", "けがわ");
            yenimetin = yenimetin.Replace("⽫", "さら");
            yenimetin = yenimetin.Replace("⽬", "め");
            yenimetin = yenimetin.Replace("⽭", "ほこ");
            yenimetin = yenimetin.Replace("⽮", "や");
            yenimetin = yenimetin.Replace("⽯", "いし");
            yenimetin = yenimetin.Replace("⽰", "しめす");
            yenimetin = yenimetin.Replace("⽱", "じゅうのあし");
            yenimetin = yenimetin.Replace("⽲", "のぎへん");
            yenimetin = yenimetin.Replace("⽳", "あな");
            yenimetin = yenimetin.Replace("⽴", "たつ");
            yenimetin = yenimetin.Replace("氺", "したみず");
            yenimetin = yenimetin.Replace("⺫", "あみがしら");
            yenimetin = yenimetin.Replace("𦉰", "あみがしら");
            yenimetin = yenimetin.Replace("⻂", "ころもへん");
            yenimetin = yenimetin.Replace("⺛", "むにょう");
            yenimetin = yenimetin.Replace("⽵", "たけ");
            yenimetin = yenimetin.Replace("⺮", "たけかんむり");
            yenimetin = yenimetin.Replace("⽶", "こめ");
            yenimetin = yenimetin.Replace("⽷", "いと");
            yenimetin = yenimetin.Replace("⽸", "みずがめ");
            yenimetin = yenimetin.Replace("⽹", "あみめ");
            yenimetin = yenimetin.Replace("⽺", "ひつじ");
            yenimetin = yenimetin.Replace("⺷", "ひつじ");
            yenimetin = yenimetin.Replace("羽", "はね");
            yenimetin = yenimetin.Replace("⽻", "はね");
            yenimetin = yenimetin.Replace("⽼", "おいかんむり");
            yenimetin = yenimetin.Replace("⽽", "しこうして");
            yenimetin = yenimetin.Replace("⽾", "らいすき");
            yenimetin = yenimetin.Replace("⽿", "みみ");
            yenimetin = yenimetin.Replace("⾀", "ふでづくり");
            yenimetin = yenimetin.Replace("⾁", "にく");
            yenimetin = yenimetin.Replace("⾂", "しん");
            yenimetin = yenimetin.Replace("⾃", "みずから");
            yenimetin = yenimetin.Replace("⾄", "いたる");
            yenimetin = yenimetin.Replace("⾅", "うす");
            yenimetin = yenimetin.Replace("⾆", "した");
            yenimetin = yenimetin.Replace("⾇", "まいあし");
            yenimetin = yenimetin.Replace("⾈", "ふね");
            yenimetin = yenimetin.Replace("⾉", "こん");
            yenimetin = yenimetin.Replace("⾊", "いろ");
            yenimetin = yenimetin.Replace("⾋", "くさ");
            yenimetin = yenimetin.Replace("⾌", "とらがしら");
            yenimetin = yenimetin.Replace("⾍", "むし");
            yenimetin = yenimetin.Replace("⾎", "ち");
            yenimetin = yenimetin.Replace("⾏", "ぎょうがまえ	");
            yenimetin = yenimetin.Replace("⾐", "ころも");
            yenimetin = yenimetin.Replace("⾑", "にし");
            yenimetin = yenimetin.Replace("⻃", "にし");
            yenimetin = yenimetin.Replace("⽠", "うり");
            yenimetin = yenimetin.Replace("⾒", "みる");
            yenimetin = yenimetin.Replace("⾓", "つの");
            yenimetin = yenimetin.Replace("⾔", "げん");
            yenimetin = yenimetin.Replace("⾕", "たに");
            yenimetin = yenimetin.Replace("⾖", "まめ");
            yenimetin = yenimetin.Replace("⾗", "いのこ");
            yenimetin = yenimetin.Replace("⾘", "むじなへん");
            yenimetin = yenimetin.Replace("⾙", "かい");
            yenimetin = yenimetin.Replace("⾚", "あか");
            yenimetin = yenimetin.Replace("⾛", "はしる");
            yenimetin = yenimetin.Replace("⾜", "あし");
            yenimetin = yenimetin.Replace("⻊", "あしへん");
            yenimetin = yenimetin.Replace("⾝", "み");
            yenimetin = yenimetin.Replace("⾞", "くるま");
            yenimetin = yenimetin.Replace("⾟", "からい");
            yenimetin = yenimetin.Replace("⾠", "しんのたつ");
            yenimetin = yenimetin.Replace("⾡", "しんにょう");
            yenimetin = yenimetin.Replace("⾢", "むら");
            yenimetin = yenimetin.Replace("⾣", "ひよみのとり");
            yenimetin = yenimetin.Replace("⾥", "さと");
            yenimetin = yenimetin.Replace("⾂", "しん");
            yenimetin = yenimetin.Replace("⻨", "むぎ");
            yenimetin = yenimetin.Replace("⾦", "かね");
            yenimetin = yenimetin.Replace("⻑", "ながい");
            yenimetin = yenimetin.Replace("⾨", "もんがまえ");
            yenimetin = yenimetin.Replace("⾩", "こざと");
            yenimetin = yenimetin.Replace("⾪", "れいづくり");
            yenimetin = yenimetin.Replace("⾫", "ふるとり");
            yenimetin = yenimetin.Replace("⾬", "あめ");
            yenimetin = yenimetin.Replace("⾭", "あお");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("⾮", "あらず");
            yenimetin = yenimetin.Replace("⻟", "しょくへん");
            yenimetin = yenimetin.Replace("⻫", "せい");
            yenimetin = yenimetin.Replace("⾯", "めん");
            yenimetin = yenimetin.Replace("⾰", "つくりがわ");
            yenimetin = yenimetin.Replace("⾲", "にら");
            yenimetin = yenimetin.Replace("⾳", "おと");
            yenimetin = yenimetin.Replace("⾴", "おおがい");
            yenimetin = yenimetin.Replace("⾵", "かぜ");
            yenimetin = yenimetin.Replace("⾶", "とぶ");
            yenimetin = yenimetin.Replace("⾷", "しょく");
            yenimetin = yenimetin.Replace("⾸", "くび");
            yenimetin = yenimetin.Replace("⾹", "かおり");
            yenimetin = yenimetin.Replace("⾺", "うま");
            yenimetin = yenimetin.Replace("⾻", "ほね");
            yenimetin = yenimetin.Replace("⾼", "たかい");
            yenimetin = yenimetin.Replace("⾽", "かみかんむり");
            yenimetin = yenimetin.Replace("⾾", "たたかいがまえ");
            yenimetin = yenimetin.Replace("⾿", "においざけ");
            yenimetin = yenimetin.Replace("⿀", "れき");
            yenimetin = yenimetin.Replace("⿁", "おに");
            yenimetin = yenimetin.Replace("⾱", "なめしがわ");
            yenimetin = yenimetin.Replace("⿂", "うお");
            yenimetin = yenimetin.Replace("⿃", "とり");
            yenimetin = yenimetin.Replace("⿄", "しお");
            yenimetin = yenimetin.Replace("⿅", "しか");
            yenimetin = yenimetin.Replace("⿆", "むぎ");
            yenimetin = yenimetin.Replace("⿇", "あさ");
            yenimetin = yenimetin.Replace("⻩", "き");
            yenimetin = yenimetin.Replace("黒", "くろ");
            yenimetin = yenimetin.Replace("⻲", "かめ");
            yenimetin = yenimetin.Replace("⿈", "き");
            yenimetin = yenimetin.Replace("⿉", "きび");
            yenimetin = yenimetin.Replace("⿊", "くろ");
            yenimetin = yenimetin.Replace("⿋", "ぬいとり");
            yenimetin = yenimetin.Replace("⻭", "は");
            yenimetin = yenimetin.Replace("⿌", "かえる");
            yenimetin = yenimetin.Replace("⿍", "かなえ");
            yenimetin = yenimetin.Replace("⿎", "つづみ");
            yenimetin = yenimetin.Replace("⿏", "ねずみ");
            yenimetin = yenimetin.Replace("⿐", "はな");
            yenimetin = yenimetin.Replace("⿑", "せい");
            yenimetin = yenimetin.Replace("⿒", "は");
            yenimetin = yenimetin.Replace("⿓", "りゅう");
            yenimetin = yenimetin.Replace("⿔", "かめ");
            yenimetin = yenimetin.Replace("⿕", "やく");
            yenimetin = yenimetin.Replace("見", "み");
            yenimetin = yenimetin.Replace("遥", "はるか");
            yenimetin = yenimetin.Replace("俺", "おれ");
            yenimetin = yenimetin.Replace("私", "わたし");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("⻘", "あお");
            yenimetin = yenimetin.Replace("りゃ", "rya");
            yenimetin = yenimetin.Replace("りゅ", "ryu");
            yenimetin = yenimetin.Replace("りょ", "ryo");
            yenimetin = yenimetin.Replace("きゃ", "kya");
            yenimetin = yenimetin.Replace("きゅ", "kyu");
            yenimetin = yenimetin.Replace("きょ", "kyo");
            yenimetin = yenimetin.Replace("しゃ", "sha");
            yenimetin = yenimetin.Replace("しゅ", "shu");
            yenimetin = yenimetin.Replace("しょ", "sho");
            yenimetin = yenimetin.Replace("ちゃ", "cha");
            yenimetin = yenimetin.Replace("ちゅ", "chu");
            yenimetin = yenimetin.Replace("ちょ", "cho");
            yenimetin = yenimetin.Replace("にゃ", "nya");
            yenimetin = yenimetin.Replace("にゅ", "nyu");
            yenimetin = yenimetin.Replace("にょ", "nyo");
            yenimetin = yenimetin.Replace("ひゃ", "hya");
            yenimetin = yenimetin.Replace("ひゅ", "hyu");
            yenimetin = yenimetin.Replace("ひょ", "hyo");
            yenimetin = yenimetin.Replace("みゃ", "mya");
            yenimetin = yenimetin.Replace("みゅ", "myu");
            yenimetin = yenimetin.Replace("みょ", "myo");
            yenimetin = yenimetin.Replace("あ", "a");
            yenimetin = yenimetin.Replace("い", "i");
            yenimetin = yenimetin.Replace("う", "u");
            yenimetin = yenimetin.Replace("え", "e");
            yenimetin = yenimetin.Replace("お", "o");
            yenimetin = yenimetin.Replace("か", "ka");
            yenimetin = yenimetin.Replace("き", "ki");
            yenimetin = yenimetin.Replace("く", "ku");
            yenimetin = yenimetin.Replace("け", "ke");
            yenimetin = yenimetin.Replace("こ", "ko");
            yenimetin = yenimetin.Replace("さ", "sa");
            yenimetin = yenimetin.Replace("し", "şi");
            yenimetin = yenimetin.Replace("す", "su");
            yenimetin = yenimetin.Replace("せ", "se");
            yenimetin = yenimetin.Replace("そ", "so");
            yenimetin = yenimetin.Replace("た", "ta");
            yenimetin = yenimetin.Replace("ち", "tçi");
            yenimetin = yenimetin.Replace("つ", "tsu");
            yenimetin = yenimetin.Replace("て", "te");
            yenimetin = yenimetin.Replace("と", "to");
            yenimetin = yenimetin.Replace("な", "na");
            yenimetin = yenimetin.Replace("に", "ni");
            yenimetin = yenimetin.Replace("ぬ", "nu");
            yenimetin = yenimetin.Replace("ね", "ne");
            yenimetin = yenimetin.Replace("は", "ha");
            yenimetin = yenimetin.Replace("ひ", "hi");
            yenimetin = yenimetin.Replace("ふ", "hu");
            yenimetin = yenimetin.Replace("へ", "he");
            yenimetin = yenimetin.Replace("ほ", "ho");
            yenimetin = yenimetin.Replace("ま", "ma");
            yenimetin = yenimetin.Replace("み", "mi");
            yenimetin = yenimetin.Replace("む", "mu");
            yenimetin = yenimetin.Replace("め", "me");
            yenimetin = yenimetin.Replace("も", "mo");
            yenimetin = yenimetin.Replace("や", "ya");
            yenimetin = yenimetin.Replace("ゆ", "yu");
            yenimetin = yenimetin.Replace("よ", "yo");
            yenimetin = yenimetin.Replace("ら", "ra");
            yenimetin = yenimetin.Replace("り", "ri");
            yenimetin = yenimetin.Replace("る", "ru");
            yenimetin = yenimetin.Replace("れ", "re");
            yenimetin = yenimetin.Replace("ろ", "ro");
            yenimetin = yenimetin.Replace("わ", "wa");
            yenimetin = yenimetin.Replace("ゐ", "wi");
            yenimetin = yenimetin.Replace("ゑ", "we");
            yenimetin = yenimetin.Replace("が", "ga");
            yenimetin = yenimetin.Replace("ぎ", "??"); 
            yenimetin = yenimetin.Replace("ギ", "gi");
            yenimetin = yenimetin.Replace("ぐ", "gu");
            yenimetin = yenimetin.Replace("げ", "ge");
            yenimetin = yenimetin.Replace("ご", "go");
            yenimetin = yenimetin.Replace("ざ", "za");
            yenimetin = yenimetin.Replace("じ", "ji");
            yenimetin = yenimetin.Replace("ず", "zu");
            yenimetin = yenimetin.Replace("ぜ", "ze");
            yenimetin = yenimetin.Replace("ぞ", "zo");
            yenimetin = yenimetin.Replace("だ", "da");
            yenimetin = yenimetin.Replace("ぢ", "ji");
            yenimetin = yenimetin.Replace("づ", "zu");
            yenimetin = yenimetin.Replace("で", "de");
            yenimetin = yenimetin.Replace("ど", "do");
            yenimetin = yenimetin.Replace("ば", "ba");
            yenimetin = yenimetin.Replace("び", "bi");
            yenimetin = yenimetin.Replace("ぶ", "bu");
            yenimetin = yenimetin.Replace("べ", "be");
            yenimetin = yenimetin.Replace("ぼ", "bo");
            yenimetin = yenimetin.Replace("ぱ", "pa");
            yenimetin = yenimetin.Replace("ぴ", "pi");
            yenimetin = yenimetin.Replace("ぷ", "pu");
            yenimetin = yenimetin.Replace("ぺ", "pe");
            yenimetin = yenimetin.Replace("ぽ", "po");
            yenimetin = yenimetin.Replace("の", "no");
            yenimetin = yenimetin.Replace("を", "wo");
            yenimetin = yenimetin.Replace("ゃ", "ya");
            yenimetin = yenimetin.Replace("ゅ", "yu");
            yenimetin = yenimetin.Replace("ょ", "yo");
            yenimetin = yenimetin.Replace("ャ", "ya");


            return yenimetin;
        }
        public String ConverterEnglish()
        {
            var metin = textBox1.Text;
            var yenimetin = "";
            yenimetin = metin.Replace("⼈", "person");
            yenimetin = yenimetin.Replace("⺅", "person");
            yenimetin = yenimetin.Replace("𠆢", "person");
            yenimetin = yenimetin.Replace("⼉", "human legs");
            yenimetin = yenimetin.Replace("⼊", "to enter");
            yenimetin = yenimetin.Replace("⼋", "eight");
            yenimetin = yenimetin.Replace("⼌", "to enclose");
            yenimetin = yenimetin.Replace("⼍", "cover/crown");
            yenimetin = yenimetin.Replace("⼎", "ice");
            yenimetin = yenimetin.Replace("⼏", "table");
            yenimetin = yenimetin.Replace("⺇", "wind");
            yenimetin = yenimetin.Replace("⼐", "container/open box");
            yenimetin = yenimetin.Replace("⼑", "knife/sword");
            yenimetin = yenimetin.Replace("⺉", "knife/sword");
            yenimetin = yenimetin.Replace("⼒", "power");
            yenimetin = yenimetin.Replace("⼓", "to wrap");
            yenimetin = yenimetin.Replace("⼔", "spoon");
            yenimetin = yenimetin.Replace("⼕", "box");
            yenimetin = yenimetin.Replace("⼖", "to conceal/hide");
            yenimetin = yenimetin.Replace("⼗", "ten");
            yenimetin = yenimetin.Replace("⼘", "oracle");
            yenimetin = yenimetin.Replace("⼙", "stamp/seal");
            yenimetin = yenimetin.Replace("⼚", "cliff");
            return  yenimetin;
        }

        void kisaltma()
        {
            var metin = "";
            var yenimetin = "";
            char Ka = 'か'; yenimetin = metin.Replace("か", "ka");
            char Ge = 'げ'; yenimetin = yenimetin.Replace("げ", "ge");
            char Ko = 'こ'; yenimetin = yenimetin.Replace("こ", "ko");
            char Go = 'ご'; yenimetin = yenimetin.Replace("ご", "go");
            char Tçi = 'ち'; yenimetin = yenimetin.Replace("ち", "tçi");
            char Şi = 'し'; yenimetin = yenimetin.Replace("し", "şi");
            char Su = 'す'; yenimetin = yenimetin.Replace("す", "su");
            char So = 'そ'; yenimetin = yenimetin.Replace("そ", "so");
            char Ta = 'た'; yenimetin = yenimetin.Replace("た", "ta");
            char Sa = 'さ'; yenimetin = yenimetin.Replace("さ", "sa");
            char Tsu = 'つ'; yenimetin = yenimetin.Replace("つ", "tsu");
            char Te = 'て'; yenimetin = yenimetin.Replace("て", "te");
            char To = 'と'; yenimetin = yenimetin.Replace("と", "to");
            char Na = 'な'; yenimetin = yenimetin.Replace("な", "na");
            char Ni = 'に'; yenimetin = yenimetin.Replace("に", "ni");
            char Nu = 'ぬ'; yenimetin = yenimetin.Replace("ぬ", "nu");
            char Ne = 'ね'; yenimetin = yenimetin.Replace("ね", "ne");
            char No = 'の'; yenimetin = yenimetin.Replace("の", "no");
            char Ha = 'は'; yenimetin = yenimetin.Replace("は", "ha");
            char Hi = 'ひ'; yenimetin = yenimetin.Replace("ひ", "hi");
            char Hu = 'ふ'; yenimetin = yenimetin.Replace("ふ", "hu");
            char He = 'へ'; yenimetin = yenimetin.Replace("へ", "he");
            char Ho = 'ほ'; yenimetin = yenimetin.Replace("ほ", "ho");
            char Ma = 'ま'; yenimetin = yenimetin.Replace("ま", "ma");
            char Mi = 'み'; yenimetin = yenimetin.Replace("み", "mi");
            char Mu = 'む'; yenimetin = yenimetin.Replace("む", "mu");
            char Me = 'め'; yenimetin = yenimetin.Replace("め", "me");
            char Mo = 'も'; yenimetin = yenimetin.Replace("も", "mo");
            yenimetin = yenimetin.Replace("ヘ", "he");
            yenimetin = yenimetin.Replace("ド", "do");
            yenimetin = yenimetin.Replace("ギ", "ba");
            yenimetin = yenimetin.Replace("へん", "hen");
            yenimetin = yenimetin.Replace("ん", "n");
            yenimetin = yenimetin.Replace("つくり", "tsukuri");
            yenimetin = yenimetin.Replace("かんむり", "kanmuri");
            yenimetin = yenimetin.Replace("あし", "ashi");
            yenimetin = yenimetin.Replace("かまえ", "kamae");
            yenimetin = yenimetin.Replace("たれ", "tare");
            yenimetin = yenimetin.Replace("にょう", "nyou");
        }

        public String TurkishConverter()
        {
            var japonca = "";
            var türkçe = "";
            return türkçe;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = RomajiConverter();
        }
    }
}
