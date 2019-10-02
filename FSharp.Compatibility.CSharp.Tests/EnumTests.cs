﻿using System;
using NUnit.Framework;
using Microsoft.FSharp.Core;
using FSharp.Compatibility.CSharp;

namespace FSharpx.CSharpTests
{
    [TestFixture]
    public class EnumTests
    {
        enum LanguageOptions
        {
            FSharp = 0,
            CSharp = 1,
            VB = 2
        }

        [Test]
        public void tryParse_can_parse_value_and_return_Some_value() =>
            Assert.AreEqual(Option.Some(LanguageOptions.CSharp), Enums.TryParse<LanguageOptions>("CSharp"));
        [Test]
        public void tryParse_returns_None_if_it_fails_to_parse() =>
            Assert.AreEqual(Option.None<LanguageOptions>(), Enums.TryParse<LanguageOptions>("English"));
        [Test]
        public void parse_returns_parsed_value()=>
            Assert.AreEqual(LanguageOptions.CSharp ,Enum.Parse<LanguageOptions>("CSharp"));

    }
}
