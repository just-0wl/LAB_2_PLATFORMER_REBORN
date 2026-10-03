using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class SimplePlayModeTest
{
    [UnityTest]
    public IEnumerator AlwaysPasses()
    {
        yield return null;
        Assert.IsTrue(true);
    }
}