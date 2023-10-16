using System.Text.Json;
using TG_Quitz;


public static class TestRepository
{
    public static List<Test> GetTests()
    {
        var stringTest = File.ReadAllText("D:\\Study\\.Net(Najot)\\C#\\TG_Quitz\\Test.json");
        var tests = JsonSerializer.Deserialize<List<Test>>(stringTest);

        return tests;
    }
}