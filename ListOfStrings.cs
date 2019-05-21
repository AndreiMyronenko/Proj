class ListOfStrings : IStringList
        {
            List<string> stringList = new List<string>();

            public void Add(string line)
            {
                stringList.Add(line);
            }
            public void Delete(string line)
            {
                stringList.Remove(line);
            }

            public IEnumerator<string> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public void Print()
            {
                foreach (var i in stringList)
                {
                    Console.WriteLine(i);
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }