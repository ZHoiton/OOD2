using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOD2_project
{
    [Serializable]
    public class Project
    {
        public int maxComponents;
        public int panelWidth;
        public int panelHeight;
        public List<Component> listComponents;
        public List<Link> listLinks;
         public Component component;
        public Link link;
        private string savedFile;

        public Project(int height, int width)
        {
            //this.maxFlow = 0;
            this.panelHeight = height;
            this.panelWidth = width;
            this.listComponents = new List<Component>();
            this.listLinks = new List<Link>();
            this.maxComponents = 20;
        }


        /// <summary>
        /// Draws the component on the woking pannel and saves the drawn component in listComponents..
        /// </summary>
        /// <param name="component"></param>
        /// <param name="gr"></param>
        /// <param name="position"></param>
        public void drawComponent(Graphics gr, Point position, Component component)
        {
            try
            {
                Rectangle rect = new Rectangle(position.X - 1, position.Y - 1, component.size, component.size);
                gr.DrawImage(component.image, rect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Check if two components are overlaping 
        /// </summary>
        /// <param name="p"></param>
        public bool checkOverlap(Point p)
        {
            Rectangle r2 = new Rectangle(p, new Size(1, 1));
            foreach (Component comp in listComponents)
            {
                //Checks the intersection
                if (comp.rect.IntersectsWith(r2))
                {
                    return true;

                }
            }
            return false;
        }

        /// <summary>
        /// Get component from the components list
        /// </summary>
        /// <param name="p"></param>
        public Component getComponent(Point p)
        {
            Rectangle r2 = new Rectangle(p, new Size(5, 5));
            foreach (Component comp in listComponents)
            {
                //Check if the clicked position intersect with some of the components
                if (r2.IntersectsWith(comp.rect))
                {
                    return comp;

                }
            }
            return null;
        }

        /// <summary>
        /// Get link from the links list
        /// </summary>
        /// <param name="link"></param>
        public Link getLink(Link link)
        {
            foreach (Link l in listLinks)
            {
                if (l == link)
                    return l;
            }
            return null;
        }
        /// <summary>
        /// Add link to the links list
        /// </summary>
        /// <param name="link"></param>
        public void AddLink(ref Link link)
        {
            if (link.startComponent is Input)
            {
                for (int i = 0; i < listComponents.Count; i++)
                {
                    if (listComponents.ElementAt(i) == link.startComponent)
                    {
                        Input input = listComponents.ElementAt(i) as Input;
                        input.setOutput(ref link);
                        if (link != null)
                        {
                            listComponents[i] = input;
                            link.startComponent = input;
                         }
                        break;
                    }
                }
            }
            else if (link.startComponent is OR)
            {
                for (int i = 0; i < listComponents.Count; i++)
                {
                    if (listComponents.ElementAt(i) == link.startComponent)
                    {
                        OR or = listComponents.ElementAt(i) as OR;
                        or.setOutput(ref link);
                        if (link != null)
                        {
                            listComponents[i] = or;
                            link.startComponent = or;
                         }
                        break;
                    }
                }

            }
            else if (link.startComponent is XOR)
            {

            for (int i = 0; i < listComponents.Count; i++)
                {
                    if (listComponents.ElementAt(i) == link.startComponent)
                    {
                        XOR xor = listComponents.ElementAt(i) as XOR;
                        xor.setOutput(ref link);
                        if (link != null)
                        {
                            listComponents[i] = xor;
                            link.startComponent = xor;
                            // this.listLinks.Add(con);
                        }
                        break;
                    }
                }
            }
            else if (link.startComponent is NOT)
            {

                for (int i = 0; i < listComponents.Count; i++)
                {
                    if (listComponents.ElementAt(i) == link.startComponent)
                    {
                        NOT not = listComponents.ElementAt(i) as NOT;
                        not.setOutput(ref link);
                        if (link != null)
                        {
                            listComponents[i] = not;
                            link.startComponent = not;
                            // this.listLinks.Add(con);
                        }
                        break;
                    }
                }
            }
            else if (link.startComponent is And)
            {

                for (int i = 0; i < listComponents.Count; i++)
                {
                    if (listComponents.ElementAt(i) == link.startComponent)
                    {
                        And and = listComponents.ElementAt(i) as And;
                        and.setOutput(ref link);
                        if (link != null)
                        {
                            listComponents[i] = and;
                            link.startComponent = and;
                            // this.listLinks.Add(con);
                        }
                        break;
                    }
                }
            }
            if (link != null)
            {
                if (link.endComponent is And)
                {
                    for (int i = 0; i < listComponents.Count; i++)
                    {
                        if (listComponents.ElementAt(i) == link.endComponent)
                        {
                            And and = listComponents.ElementAt(i) as And;
                            Rectangle r1 = new Rectangle(link.curvePoints[link.curvePoints.Count() - 1], new Size(2, 2));
                            if (r1.IntersectsWith(and.lowerLeft))
                            {
                                and.setLowInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = and;
                                    link.endComponent = and;
                                    if (and.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == and.Output)
                                            {
                                                x.value = and.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }

                            else if (r1.IntersectsWith(and.upperLeft))
                            {
                                and.setUpInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = and;
                                    link.endComponent = and;
                                    if (and.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == and.Output)
                                            {
                                                x.value = and.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }
                        }

                    }
                }

                else if (link.endComponent is Output)
                {
                    for (int i = 0; i < listComponents.Count; i++)
                    {
                        if (listComponents.ElementAt(i) == link.endComponent)
                        {
                            Output o = listComponents.ElementAt(i) as Output;
                            o.setInput(ref link);
                            if (link != null)
                            {
                                listComponents[i] = o;
                                link.endComponent = o;
                                this.listLinks.Add(link);
                            }

                            break;
                        }
                    }
                }
                else if (link.endComponent is OR)
                {

                    for (int i = 0; i < listComponents.Count; i++)
                    {
                        if (listComponents.ElementAt(i) == link.endComponent)
                        {
                            OR or = listComponents.ElementAt(i) as OR;
                            Rectangle r1 = new Rectangle(link.curvePoints[link.curvePoints.Count() - 1], new Size(2, 2));
                            if (r1.IntersectsWith(or.lowerLeft))
                            {
                                or.setLowInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = or;
                                    link.endComponent = or;
                                    if (or.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == or.Output)
                                            {
                                                x.value = or.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }

                            else if (r1.IntersectsWith(or.upperLeft))
                            {
                                or.setUpInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = or;
                                    link.endComponent = or;
                                    if (or.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == or.Output)
                                            {
                                                x.value = or.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }
                        }

                    }
                }
                else if (link.endComponent is NOT)
                {

                    for (int i = 0; i < listComponents.Count; i++)
                    {
                        if (listComponents.ElementAt(i) == link.endComponent)
                        {
                            NOT not = listComponents.ElementAt(i) as NOT;
                            Rectangle r1 = new Rectangle(link.curvePoints[link.curvePoints.Count() - 1], new Size(2, 2));
                             
                           if (r1.IntersectsWith(not.inLeft))
                            {
                                not.setUpInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = not;
                                    link.endComponent = not;
                                    if (not.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == not.Output)
                                            {
                                                x.value = not.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }
                        }

                    }
                }

                else if (link.endComponent is XOR)
                {

                    for (int i = 0; i < listComponents.Count; i++)
                    {
                        if (listComponents.ElementAt(i) == link.endComponent)
                        {
                            XOR xor = listComponents.ElementAt(i) as XOR;
                            Rectangle r1 = new Rectangle(link.curvePoints[link.curvePoints.Count() - 1], new Size(2, 2));
                            if (r1.IntersectsWith(xor.lowerLeft))
                            {
                                xor.setLowInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = xor;
                                    link.endComponent = xor;
                                    if (xor.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == xor.Output)
                                            {
                                                x.value = xor.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }

                            else if (r1.IntersectsWith(xor.upperLeft))
                            {
                                xor.setUpInput(ref link);
                                if (link != null)
                                {
                                    listComponents[i] = xor;
                                    link.endComponent = xor;
                                    if (xor.Output != null)
                                    {
                                        foreach (Link x in listLinks)
                                        {
                                            if (x == xor.Output)
                                            {
                                                x.value = xor.outValue;
                                            }
                                        }
                                    }
                                    this.listLinks.Add(link);
                                }
                                break;
                            }
                        }

                    }

                }
            }
        }


        /// <summary>
        /// Remove component from the components list
        /// </summary>
        /// <param name="comp"></param>
        public void RemoveComponent(Component comp)
        {
            List<Link> toRemove = new List<Link>();
            Component losesInput = null;
            foreach(Link checkIfOutput in toRemove)
            {
                if(checkIfOutput.startComponent == comp)
                {
                    losesInput = checkIfOutput.endComponent;
                }
            }

            foreach (Link x in listLinks)
            {
                if (x.startComponent == comp)
                {
                    int counter = 0;
                    foreach (Component y in listComponents)
                    {
                        if (y == x.endComponent)
                        {
                            if (y is Input)
                            {
                                Input i = y as Input;
                                i.Clear();
                                listComponents[counter] = i;
                            }
                            else if (y is OR)
                            {
                                OR i = y as OR;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is XOR)
                            {
                                XOR i = y as XOR;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is NOT)
                            {
                                NOT i = y as NOT;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is And)
                            {
                                And i = y as And;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }

                        }
                        counter++;
                    }
                    toRemove.Add(x);
                   

                }
                if (x.endComponent == comp)
                {
                    int counter = 0;
                    foreach (Component y in listComponents)
                    {
                        if (y == x.startComponent)
                        {
                            if (y is Output)
                            {
                                Output s = y as Output;
                                s.Clear();
                                listComponents[counter] = s;
                            }
                            else if (y is OR)
                            {
                                OR s = y as OR;
                                s.Clear(x);
                                listComponents[counter] = s;
                            }
                            else if (y is XOR)
                            {
                                XOR s = y as XOR;
                                s.Clear(x);
                                listComponents[counter] = s;
                            }
                            else if (y is NOT)
                            {
                                NOT i = y as NOT;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is And)
                            {
                                And s = y as And;
                                s.Clear(x);
                                listComponents[counter] = s;
                            }

                        }
                    }
                    toRemove.Add(x);
                    
                }
            }

            

            foreach (Link l1 in toRemove)
            {
                listLinks.Remove(l1);
            }
            // this.RemoveLink();
            this.listComponents.Remove(comp);
            if(losesInput != null)
            {
                losesInput.CalculateValue();
            }
         }

        /// <summary>
        /// Remove link from the links list
        /// </summary>
        /// <param name="comp"></param>
        public void RemoveLink(Component comp)
        {
            // this.listLinks.Remove(l);
            List<Link> toRemove = new List<Link>();
            List<Component> compToClear = new List<Component>();

            foreach (Link x in listLinks)
            {
                if (x.startComponent == comp)
                {
                    int counter = 0;
                    foreach (Component y in listComponents)
                    {
                        if (y == x.endComponent)
                        {
                            if (y is Input)
                            {
                                Input s = y as Input;
                                s.Clear();
                                // listComponents[counter] = s;
                            }
                            else if (y is OR)
                            {
                                OR s = y as OR;
                                s.Clear(x);
                                //  listComponents[counter] = s;
                            }
                            else if (y is XOR)
                            {
                                XOR s = y as XOR;
                                s.Clear(x);
                                //  listComponents[counter] = s;
                            }
                            else if (y is NOT)
                            {
                                NOT i = y as NOT;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is And)
                            {
                                And s = y as And;
                                s.Clear(x);
                                //  listComponents[counter] = s;
                            }

                        }
                        counter++;
                    }
                    toRemove.Add(x);
                    compToClear.Add(x.startComponent);
                    compToClear.Add(x.endComponent);
                }
                if (x.endComponent == comp)
                {
                    int counter = 0;
                    foreach (Component y in listComponents)
                    {
                        if (y == x.startComponent)
                        {
                            if (y is Output)
                            {
                                Output s = y as Output;
                                s.Clear();
                                //  listComponents[counter] = s;
                            }
                            else if (y is OR)
                            {
                                OR s = y as OR;
                                s.Clear(x);
                                //  listComponents[counter] = s;
                            }
                            else if (y is XOR)
                            {
                                XOR s = y as XOR;
                                s.Clear(x);
                                //listComponents[counter] = s;
                            }
                            else if (y is NOT)
                            {
                                NOT i = y as NOT;
                                i.Clear(x);
                                listComponents[counter] = i;
                            }
                            else if (y is And)
                            {
                                And s = y as And;
                                s.Clear(x);
                                //listComponents[counter] = s;
                            }

                        }
                    }
                    toRemove.Add(x);
                    compToClear.Add(x.startComponent);
                    compToClear.Add(x.endComponent);
                }
            }
            foreach (var c in compToClear)
            {
                ClearSettings(c);
            }
            foreach (Link c1 in toRemove)
            {
                listLinks.Remove(c1);
            }

        }




        internal void ClearSettings(Component comp)
        {
            if (comp is Input)
            {
                Input i = comp as Input;
                 i.Clear();
            }
            else if (comp is And)
            {
                foreach (Link x in listLinks)
                {
                    And m = comp as And;
                    m.Clear(x);
                    m.Clear();
                }
            }
            else if (comp is XOR)
            {
                foreach (Link x in listLinks)
                {
                    XOR s = comp as XOR;
                    s.Clear(x);
                    s.Clear();

                }
            }
            else if (comp is NOT)
            {
                foreach (Link x in listLinks)
                {
                    NOT s = comp as NOT;
                    s.Clear(x);
                    s.Clear();

                }
            }
            else if (comp is OR)
            {
                foreach (Link x in listLinks)
                {
                    OR s = comp as OR;
                    s.Clear(x);
                    s.Clear();

                }
            }
            else if (comp is Output)
            {
                Output s = comp as Output;
                s.Clear();
               
            }
                     
            }
        }


    }

