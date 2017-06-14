using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class Project
    {
        private List<Component> components;

        public List<Component> Components
        {
            get { return components; }
            set { components = value; }
        }
        private List<Link> links;

        public List<Link> Links
        {
            get { return links; }
            set { links = value; }
        }
        public Project()
        {
            //todo
        }
        public bool addComponent(string type, Component component)
        {
            return false;
            //todo
        }
        public Component getComponent(Point location)
        {
            //toq i removeComponent mislq che shte e po dobre kato parametur da zimat 
            //Component a ne location, tui s namiraneto moje da go pravime v form-ta
            //i tuka samo da predavame componenta ako e nameren
            return null;
            //todo
        }
        public void removeComponent(Point location)
        {
            //todo
        }
        public void addLink(Component startingComponent, Component endingComponent)
        {
            //todo
            //i tuka vlesto parametur (Component startingComponent, Component endingComponent)
            //moje presto Link da zimame i da access-vame dvete neshta i tova za i 3te methoda
            {
                //todo
            }
        }
        public Link getLink(Component startingComponent, Component endingComponent)
        {
            return null;
            //todo
        }
        public void removeLink(Component startingComponent, Component endingComponent)
        {
            //todo
        }
    }
}
