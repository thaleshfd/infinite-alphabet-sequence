
# infinite-alphabet-sequence | ![.NET Core](https://github.com/thaleshfd/infinite-alphabet-sequence/workflows/.NET%20Core/badge.svg?branch=master)

Infinite alphabet sequence generator
e.g. A -> B -> C -> ..... -> Z -> AA -> AB.

## Getting Started

If you need to get the next alphabet letter infinitely that's what you need. 

### Installing

Via nuget:
```
Install-Package InfiniteAlphabetSequence -Version 1.0.5
```

## Unit tests

Tests created to simulate the possibilities.

```
[TestMethod]
public void WhenStringEmpty_ReturnFirstAlphabetLetter()
{
    var sequence = InfiniteAlphabetSequence.Generate("");
    Assert.AreEqual("A", sequence);
}

[TestMethod]
public void WhenLastAlphabetLetter_StartsFromTheBegining()
{
    var sequence = InfiniteAlphabetSequence.Generate("Z");
    Assert.AreEqual("AA", sequence);
}

[TestMethod]
public void IfSequenceWithOneCharacter_ReturnNextOfTheSequence()
{
    var sequence = InfiniteAlphabetSequence.Generate("G");
    Assert.AreEqual("H", sequence);
}
```

## Contributing

Please read [CONTRIBUTING.md](https://github.com/thaleshfd/infinite-alphabet-sequence/blob/master/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Authors

* **Thales Drosghic** - *Initial work* - [thaleshfd](https://github.com/thaleshfd)

See also the list of [contributors](https://github.com/thaleshfd/infinite-alphabet-sequence/contributors) who participated in this project.


