using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeCellMetrics.Classes
{
    public class Game
    {
        //<Button Grid.Row="1" Grid.Column="4" Content="4-S" Tag="14S4" x:Name="S4"/>
        public void Generate()
        {
            StringBuilder res = new StringBuilder();

            List<Card> genCards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var c = new Card()
                    {
                        Value = j + 1,
                    };

                    c.Color = i.ToString();

                    switch (i)
                    {
                        case 1:c.Color = "S";
                            break;
                        case 2: c.Color = "H";
                            break;
                        case 3: c.Color = "D";
                            break;
                        case 0: c.Color = "C";
                            break;
                        default:
                            break;
                    }

                    genCards.Add(c);                   
                }
            }

            bool isHalf = false;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    isHalf = i == 6 && j > 3;                    
                    if (isHalf)
                        break;

                    if (genCards.Count == 0)
                        break;

                    Card randCard = genCards[new Random().Next(0, genCards.Count)];
                    randCard.isRed = TagReader.parseColorRed(randCard);
                    genCards.Remove(randCard);
                                        
                    string bckgrnd = string.Empty;
                    if (randCard.isRed) { bckgrnd = "Background=\"" + "Red" + "\""; };

                    res.AppendLine("<Button Grid.Row=" + "\"" + (i + 1) + "\""
                        + " Grid.Column=" + "\"" + (j + 1) + "\""
                        + " Content=" + "\"" + randCard.Value + "-" + randCard.Color + "\""
                        + " Tag=" + "\"" + (i + 1) + "" + (j + 1) + "" + randCard.Color + "" + randCard.Value + "\""
                        + " x:Name=" + "\"" + randCard.Color + randCard.Value + "\"" 
                        + " " + bckgrnd + " "
                        + "/>");
                }
            }
        }
    }
}
