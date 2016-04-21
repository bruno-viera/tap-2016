using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //Criada a classe clsOrdenacao
    public static class clsOrdenacao
    {
        //Método que divide a lista a ser ordenada em grupos menores e aplica o método de ordenação por inserção
        public static List<int> Shell (List<int> list)
        {
            //São declaradas as variáveis
            int aux = 1;
            int num = list.Count();
            //laço de repetição
            //condição dentro do parêntese 
            while (aux < num)
            {
                aux = aux * 3 + 1;
            }

            aux = aux / 3;
            int c, j;
            while (aux > 0)
            {
                for (int i = aux; i < num; i++)
                {
                    c = list[i];
                    j = i;
                    while (j >= aux && list[j - aux] > c)
                    {
                        list[j] = list[j - aux];
                        j = j - aux;
                    }
                    list[j] = c;
                }
                aux = aux / 2;
            }
            return list;
        }

        //Método que ordena a lista em ambas as direções
        public static List<int> Cocktail(List<int> list)
        {
            //São declaradas as variáveis
            int tam, comeco, final, troca, aux;
            tam = list.Count();
            comeco = 0;
            final = tam - 1;
            troca = 0;
            //laço de repetição
            //condição dentro do parêntese
            while (troca == 0 && comeco < final)
            {
                troca = 1;
                for (int i = comeco; i < final; i = i + 1)
                {
                    if (list[i] > list[i + 1])
                    {
                        aux = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = aux;
                        troca = 0;
                    }
                }

                final = final - 1;

                for (int i = final; i > comeco; i = i - 1)
                {
                    if (list[i] < list[i - 1])
                    {
                        aux = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = aux;
                        troca = 0;
                    }
                }

                comeco = comeco + 1;
            }

            return list;
        }

        //Método de ordenação que percorre um vetor ordenando os elementos a esquerda a medida que avança
        public static List<int> Insercao(List<int> list)
        {
            //variáveis
            int x, aux;
            //laço de repetição
            //condição dentro do parêntese
            for (int i = 1; i < list.Count(); i++)
            {
                x = i;
                while ((x > 0) && (list[x - 1] > list[x]))
                {
                    aux = list[x - 1];
                    list[x - 1] = list[x];
                    list[x] = aux;
                    x--;
                }
            }
            return list;
        }

        // Método de ordenação por troca
        public static List<int> Comb(List<int> list)
        {
            //variáveis
            int aux = list.Count();
            bool swapped = true;
            //laço de repetição
            //condição dentro do parêntese
            while (aux > 1 || swapped)
            {
                if (aux > 1)
                {
                    aux = (int)(aux / 1.247330950103979);
                }

                int i = 0;
                swapped = false;
                while (i + aux < list.Count())
                {
                    if (list[i].CompareTo(list[i + aux]) > 0)
                    {
                        int t = list[i];
                        list[i] = list[i + aux];
                        list[i + aux] = t;
                        swapped = true;
                    }
                    i++;
                }
            }

            return list;
        }

        //Método similar ao de inserção, a diferença é que esse leva o elemento para a posição certa
        public static List<int> Gnome(List<int> list)
        {
            //variáveis
            int g = 0;
            int aux;
            //laço de repetição
            //condição dentro do parêntese
            while (g < (list.Count() - 1))
            {
                if (list[g] > list[g + 1])
                {
                    aux = list[g];
                    list[g] = list[g + 1];
                    list[g + 1] = aux;
                    if (g > 0)
                    {
                        g -= 2;
                    }
                }
                g++;
            }

            return list;
        }
    }
}
