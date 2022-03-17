namespace GameLibrary;

// TODO: Vytvořte třídu UpdatedStatsEventArgs, která je potomkem EventArgs
// - a obsahuje vlastnosti (get & init)
// -- int Correct
// -- int Missed
// -- int Accuracy
public class UpdatedStatsEventArgs : EventArgs
{
    public int Correct { get; init; }
    public int Missed { get; init; }
    public int Accuracy { get; init; }
}
// TODO: Vytvořte delegát UpdatedStatsEventHandler pro příslušnou událost, využijte výše definované argumenty
public delegate void UpdatedStatsEventHandler(object sender, UpdatedStatsEventArgs e);
// TODO: Dokončete třídu Stats...
public class Stats
{
    // TODO: Vytvořte vlastnosti určené pro čtení:
    // - int Correct
    // - int Missed
    // - Int Accuracy
    public int Correct { get; set; }
    public int Missed { get; set; }
    public int Accuracy { get; set; }

    // TODO: Vytvořte veřejnou událost UpdatedStats (UpdatedStatsEventHandler?)
    public event UpdatedStatsEventHandler? UpdatedStats;

    // TODO: Vytvořte veřejnou metodu Update
    // - parametr - bool correctKey - určuje zdali byla stisknuta správná klávesa a jedná se o Correct zásah či o Missed zásah
    // - na základě parametru inkrementujte Correct nebo Missed vlastnost
    // - vypočtěte hodnotu Accuracy jako procentuální přesnost (na základě Correct a Missed, vypočtená hodnota 0-100 %)
    // - vyvolejte událost UpdatedStats a předejte pomocí event args aktuální stav vlastností
    public void Update(bool correctKey)
    {

        if (correctKey)
        {
            Correct++;
        }
        else
        {
            Missed++;
        }
        int celkem = Correct + Missed;
        Accuracy = (int)Math.Round((Correct * 100.0) / celkem, MidpointRounding.AwayFromZero);
        UpdatedStats?.Invoke(this, new UpdatedStatsEventArgs() { Correct = Correct, Missed = Missed, Accuracy = Accuracy });
    }

    // TODO: Vytvořte veřejnou metodu Reset
    // - metoda vynuluje vlasnosti Correct, Missed, Accuracy
    // - metoda nijak nemění stav události UpdatedStats a ani ji nevyvolává
    public void Reset()
    {
        Correct = 0;
        Missed = 0; 
        Accuracy = 0;
    }
}
