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

namespace FinalPrepAssignment {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        Random anigen = new Random();
        Random selectName = new Random();

        enum GenName { Phill, Wiskers, Bill, Angel, Fluffy }
        // selects name for list to be given to new animals
        public string SetName() {

            GenName select = (GenName)selectName.Next(5);

            return select.ToString();

        }



        private void btnCat_Click(object sender, RoutedEventArgs e) {
            Cat first = new Cat(SetName());
            lbOutput.Items.Add( first.ToString());
        }

        private void btnShelter_Click(object sender, RoutedEventArgs e) {
            Shelter<Animal> test = new Shelter<Animal>();
            int count = 0;
            //fills the shelter with 100 animals of random type and prins out the list sorted by name
            for (int i = 0; i < 100; i++) {
                int ani = anigen.Next(3);
                Animal inhab;
                
                if (ani == 0) {
                    inhab = new Cat(SetName());
                } else if (ani == 1) {
                    inhab = new Dog(SetName());
                } else {
                    inhab = new Rabbit(SetName());
                }
                count++;
                test.Inhabitants.Add(inhab);
                test.Inhabitants.Sort();
                lbOutput.Items.Add(string.Format("{0}. {1}", count.ToString(), test.Inhabitants[i].ToString()));
            }

            int countDog = 0;
            int countCat = 0;
            int countRabbit = 0;
            // counts how many of each animal type is in the  shelter
            foreach (var ani in test.Inhabitants) {
                if (ani.ToString()[0]=='*') {
                    countDog++;
                } else if (ani.ToString()[0]=='+') {
                    countCat++;
                } else {
                    countRabbit++;
                }
            }
            lbOutput.Items.Add(string.Format("There are {0} Dogs, {1} Cats, and {2} Rabbits", countDog, countCat, countRabbit));
            
        }
        /// <summary>
        /// Clears the ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e) {
            lbOutput.Items.Clear();
        }
    }
}
