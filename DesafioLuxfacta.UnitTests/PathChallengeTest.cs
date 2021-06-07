using DesafioLuxfacta.ConsoleApplication.Challenges;
using DesafioLuxfacta.ConsoleApplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesafioLuxfacta.UnitTests
{
    public class PathChallengeTest
    {
        [Fact]
        public void ChangeCurPath_Equals()
        {
            Path p = new Path("/a/b/c/d");
            p.Cd("../x");
            Assert.Equal("/a/b/c/x", p.CurrentPath);
        }

        [Fact]
        public void TwoTimesDown_Equals()
        {
            Path p = new Path("/a/b/c/d");
            p.Cd("../../x");
            Assert.Equal("/a/b/x", p.CurrentPath);
        }

        [Fact]
        public void MiddleParentDir_Equals()
        {
            Path p = new Path("/a/b/c/d");
            p.Cd("a/../x");
            Assert.Equal("/a/b/c/d/x", p.CurrentPath);
        }

        [Fact]
        public void ThreeTimesUp_Equals()
        {
            Path p = new Path("/a/b/c");
            p.Cd("d/e/f");
            Assert.Equal("/a/b/c/d/e/f", p.CurrentPath);
        }

        [Fact]
        public void DoubleStash_Equals()
        {
            Path p = new Path("/a/b/c");
            p.Cd("d//e/f");
            Assert.Equal("/a/b/c/d/e/f", p.CurrentPath);
        }

        [Fact]
        public void RootPath_Equals()
        {
            Path p = new Path("/a/b/c");
            p.Cd("/d/e/f");
            Assert.Equal("/d/e/f", p.CurrentPath);
        }

        [Fact]
        public void BackToRootPath_Equals()
        {
            Path p = new Path("/a/b/c");
            p.Cd("/");
            Assert.Equal("/", p.CurrentPath);
        }

        [Fact]
        public void ParentFromRootPath_Equals()
        {
            Path p = new Path("/");
            p.Cd("..");
            Assert.Equal("/", p.CurrentPath);
        }

        [Fact]
        public void InvalidPath_Throws()
        {
            Path p = new Path("/a/b/c");
            Assert.Throws<InvalidPathException>(() => p.Cd("/?"));

            Assert.Throws<InvalidPathException>(() => p.Cd("./d"));

            Assert.Throws<InvalidPathException>(() => p.Cd(".../d"));

            Assert.Throws<InvalidPathException>(() => p.Cd("..../d"));
        }
    }
}