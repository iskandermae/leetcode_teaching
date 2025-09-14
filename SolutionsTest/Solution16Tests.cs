namespace SolutionsTest {
    [TestClass]
    public sealed class Solution16Tests {
        [TestMethod]
        public void HasPathSum_PathExists_PathFound() {

            // [1,2,3]
            var data = new Leetcode.Solutions.Solution16.TreeNode(1,
                new Leetcode.Solutions.Solution16.TreeNode(2),
                new Leetcode.Solutions.Solution16.TreeNode(3)
                );



            var t = new Leetcode.Solutions.Solution16();

            Assert.IsTrue(t.HasPathSum(data, 4));
        }

        [TestMethod]
        public void HasPathSum_ComplexPathExists_PathFound() {

            // [1,-2,-3,1,3,-2,null,-1]
            var data = new Leetcode.Solutions.Solution16.TreeNode(1,
                new Leetcode.Solutions.Solution16.TreeNode(-2,

                new Leetcode.Solutions.Solution16.TreeNode(1,


                new Leetcode.Solutions.Solution16.TreeNode(-1),
                null
                ),
                new Leetcode.Solutions.Solution16.TreeNode(3)
                ),
                new Leetcode.Solutions.Solution16.TreeNode(-3,

                new Leetcode.Solutions.Solution16.TreeNode(-2),
                null)
                );



            var t = new Leetcode.Solutions.Solution16();

            Assert.IsTrue(t.HasPathSum(data, 2));
        }

        [TestMethod]
        public void HasPathSum_ComplexPathExists2_PathFound() {

            // [1,-2,-3,1,3,-2,null,-1]
            var data = new Leetcode.Solutions.Solution16.TreeNode(1,
                new Leetcode.Solutions.Solution16.TreeNode(-2,

                    new Leetcode.Solutions.Solution16.TreeNode(1,
                        new Leetcode.Solutions.Solution16.TreeNode(-1),
                        null
                    ),
                    new Leetcode.Solutions.Solution16.TreeNode(3)
                    ),
                new Leetcode.Solutions.Solution16.TreeNode(-3,
                    new Leetcode.Solutions.Solution16.TreeNode(-2),
                    null
                 )
             );



            var t = new Leetcode.Solutions.Solution16();

            Assert.IsTrue(t.HasPathSum(data, -4));
        }

        [TestMethod]
        public void HasPathSum_PathNotExists_PathNotFound() {

            // [1,2,3]
            var data = new Leetcode.Solutions.Solution16.TreeNode(1,
                new Leetcode.Solutions.Solution16.TreeNode(2),
                new Leetcode.Solutions.Solution16.TreeNode(3)
                );
            var t = new Leetcode.Solutions.Solution16();

            Assert.IsFalse(t.HasPathSum(data, 5), "Expected false - no path in input parameters");
        }



        [TestMethod]
        public void HasPathSum_PathNotExistsNonSymmetric_PathNotFound() {

            // [1,2,3]
            var data = new Leetcode.Solutions.Solution16.TreeNode(1,
                new Leetcode.Solutions.Solution16.TreeNode(2),
                null
                );
            var t = new Leetcode.Solutions.Solution16();

            Assert.IsFalse(t.HasPathSum(data, 0), "Expected false - no path in input parameters");
        }


        [TestMethod]
        public void HasPathSum_EmptyPath_PathNotFound() {

            // [1,2,3]
            Leetcode.Solutions.Solution16.TreeNode data = null;



            var t = new Leetcode.Solutions.Solution16();

            Assert.IsFalse(t.HasPathSum(data, 0));
        }
    }
}
