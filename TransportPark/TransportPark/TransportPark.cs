
namespace TransportPark
{
    public class TransportPark
    {
        private List<Transport> transports = new List<Transport>();

        public void AddTransport(Transport transport)
        {
            transports.Add(transport);
        }


        public void ShowAllTransports()
        {
            foreach (var transport in transports)
            {
                transport.ShowInfo();
                Console.WriteLine();
            }
        }
        
        public void StartTransport(int index)
        {
            if (index >= 0 && index < transports.Count)
            {
                transports[index].Move();
            }
            else
            {
                Console.WriteLine("Неверный индекс!");
            }
        }

        public void RemoveTransport(int index)
        {
            if (index >= 0 && index < transports.Count)
            {
                transports.RemoveAt(index);
                Console.WriteLine("Транспорт удален.");
            }
            else
            {
                Console.WriteLine("Неверный индекс!");
            }
        }

        public void FilterByType(string type)
        {
            var filteredTransports = transports.FindAll(t => t.Type == type);
            foreach (var transport in filteredTransports)
            {
                transport.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}