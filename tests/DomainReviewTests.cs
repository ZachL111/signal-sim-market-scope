using SignalSimMarketScope;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(49, 33, 31, 53);
        if (DomainReviewLens.Score(item) != 91) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "hold") throw new Exception("domain lane mismatch");
    }
}
