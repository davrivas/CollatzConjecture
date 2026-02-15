using System.Collections.Generic;

namespace CollatzConjecture
{
    public class Model
    {
        public int Number { get; set; }
        public List<int> Steps { get; set; } = [];
        public string StepsStr => string.Join(", ", Steps);

        public Model(int num)
        {
            Number = num;

            while (num > 1)
            {
                num = num % 2 == 0
                    ? num / 2
                    : 3 * num + 1;
                Steps.Add(num);
            }
        }
    }
}
