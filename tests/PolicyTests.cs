using SignalSimMarketScope;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(76, 93, 27, 21, 6);
        if (Policy.Score(signalcase_1) != 95) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(75, 90, 27, 17, 4);
        if (Policy.Score(signalcase_2) != 98) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(93, 91, 16, 7, 11);
        if (Policy.Score(signalcase_3) != 260) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
