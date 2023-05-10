using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PR3;

namespace PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<player> players;
        List<questions> quuestions;
        string a;
        int v;

        public MainWindow()
        {
            InitializeComponent();
            players = new List<player>()
            {
                new player("Настя", 0),
                new player("Ильдар", 0),
                new player("Рома", 0),

            };
            Update();
            quuestions = new List<questions>()
            {
                new questions("Какому ученому на голову упало яблоко:","Ньютон", 100),
                new questions("Основные труды этого математика по математическому анализу, теории функций, алгебре и теории чисел","Гурвиц", 200),
                new questions("Швейцарский физик, механик и математик, один из создателей кинетической теории газов, гидродинамики и математической физики:","Бернулли", 300),
                new questions("Немецкий математик и астроном-теоретик. Знаменит тем, что установил существование односторонних поверхностей, названных позднее в честь него:","Мебиус", 400),
                new questions("Этот ученый больше известен своими открытиями в алгебре, тем не менее, на своем надгробном памятнике он завещал выгравировать правильный 17-угольник, вписанный в круг:","Гаусс", 500),

                new questions("Самый распространенный металл на земле? ","Аллюминий", 100),
                new questions("Какой элемент является активной частью гормонов щитовидной железы? ","Йод", 200),
                new questions("Этот элемент является фактором активации витамина В12, поэтому этот элемент незаменим для нормального протекания процесса образования крови ", "Кобальт", 300),
                new questions("Что такое «известковое молоко»? ","Шидроксид кальция", 400),
                new questions("Каустическая сода – это...","гидроксид натрия", 500),

                new questions("В конце XIX в. именно этих насекомых для исследования сыпного тифа Пастеровский институт вынужден был импортировать из России.","Вши", 100),
                new questions("От прочих злаков этот отличается тем, что растет под слоем воды. Один из его сортов переносит затопление слоем воды до 4 м. Требуется 5 тыс. л воды, чтобы произвести 1 кг зерен этого злака","Рис ", 200),
                new questions("Этот фрукт, употребляемый в сыром виде, признан самым питательным в мире, а испанцы из-за зеленой пупырчатой шкурки прозвали его «аллигаторовой грушей»", "Авокадо", 300),
                new questions("Назовите единственного эндемичного представителя отряда хищных Австралии, но не из сумчатых хищников. ","динго", 400),
                new questions("Эта рыбка, поедая личинок малярийного комара, помогла превратить город Сочи в курорт. ","Гамбузия", 500),

                new questions("2+2*2=","6", 100),
                new questions("Создатель системы координат? ","Декарт", 200),
                new questions("Как называется наука, изучающая свойство фигур на плоскости?", "Планиметрия", 300),
                new questions("Что нужно найти в первую очередь, решая квадратное уравнение?","Дискриминант", 400),
                new questions("Как называется независимая переменная?","Аргумент", 500),

                new questions("Что такое звезда?","раскаленный газ", 100),
                new questions("В каком созвездии находится Полярная звезда?","Малая медведица", 200),
                new questions("Назовите ближайшую к нам звезду.", "Солнце", 300),
                new questions("Как называется наука, изучающая строение и эволюцию Вселенной?","Космология", 400),
                new questions("Как называется основной объект Вселенной – скопление огромного числа звезд?","Галактика", 500),
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[0].question;
            a = quuestions[0].answer;
            v = quuestions[0].Point;
        }

        public void Update()
        {

            players = players.ToList();
            list1.ItemsSource = players;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b2.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[1].question;
            a = quuestions[1].answer;
            v = quuestions[1].Point;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            b3.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[2].question;
            a = quuestions[2].answer;
            v = quuestions[2].Point;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            b4.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[3].question;
            a = quuestions[3].answer;
            v = quuestions[3].Point;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            b5.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[4].question;
            a = quuestions[4].answer;
            v = quuestions[4].Point;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            b6.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[5].question;
            a = quuestions[5].answer;
            v = quuestions[5].Point;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            b7.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[6].question;
            a = quuestions[6].answer;
            v = quuestions[6].Point;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            b8.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[7].question;
            a = quuestions[7].answer;
            v = quuestions[7].Point;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            b9.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[8].question;
            a = quuestions[8].answer;
            v = quuestions[8].Point;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            b10.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[9].question;
            a = quuestions[9].answer;
            v = quuestions[9].Point;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            b11.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[10].question;
            a = quuestions[10].answer;
            v = quuestions[10].Point;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            b12.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[11].question;
            a = quuestions[11].answer;
            v = quuestions[11].Point;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            b13.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[12].question;
            a = quuestions[12].answer;
            v = quuestions[12].Point;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            b14.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[13].question;
            a = quuestions[13].answer;
            v = quuestions[13].Point;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            b15.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[14].question;
            a = quuestions[14].answer;
            v = quuestions[14].Point;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            b16.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[15].question;
            a = quuestions[15].answer;
            v = quuestions[15].Point;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            b17.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[16].question;
            a = quuestions[16].answer;
            v = quuestions[16].Point;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            b18.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[17].question;
            a = quuestions[17].answer;
            v = quuestions[17].Point;
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            b19.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[18].question;
            a = quuestions[18].answer;
            v = quuestions[18].Point;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            b20.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[19].question;
            a = quuestions[19].answer;
            v = quuestions[10].Point;
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            b21.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[20].question;
            a = quuestions[20].answer;
            v = quuestions[20].Point;
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            b22.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[21].question;
            a = quuestions[21].answer;
            v = quuestions[21].Point;
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            b23.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[22].question;
            a = quuestions[22].answer;
            v = quuestions[22].Point;
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            b24.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[23].question;
            a = quuestions[23].answer;
            v = quuestions[23].Point;
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            b25.Visibility = Visibility.Collapsed;
            vopr.Text = quuestions[24].question;
            a = quuestions[24].answer;
            v = quuestions[24].Point;
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            try
            {
                if (otv.Text == a)
                {
                    if (list1.SelectedItem == null)
                    {
                    }
                    int c = v;
                    var b = players.FindIndex(u => u == list1.SelectedItem);
                    players[b].Point = players[b].Point + c;
                    Update();
                }

                vopr.Text = "";
                otv.Text = "";
                Update();
            }
            catch (System.Exception)
            {
                otv.Text = "";
                vopr.Text = "";
                MessageBox.Show("Выберети пользователя");
            }
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            player player1 = players[0];
            foreach (var a in players)
            {
                if (player1.Point < a.Point) player1 = a;
            }
            MessageBox.Show(player1.Name, "Победитель");
        }
    }
}
