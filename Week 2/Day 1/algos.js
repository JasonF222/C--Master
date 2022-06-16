/**
 * Class to represent a Node in a Binary Search Tree (BST).
 */
class BSTNode {
    /**
     * Constructs a new instance of a BST node.
     * @param {number} data The integer to store in the node.
     */
    constructor(data) {
    this.data = data;
    /**
       * These properties are how this node is connected to other nodes to form
       * the tree. Similar to .next in a SinglyLinkedList except a BST node can
       * be connected to two other nodes. To start, new nodes will not be
       * connected to any other nodes, these properties will be set after
       * the new node is instantiated.
       *
       * @type {BSTNode|null}
       */
    this.left = null;
      /** @type {BSTNode|null} */
    this.right = null;
    }
}

    /**
   * Represents an ordered tree of nodes where the data of left nodes are <= to
   * their parent and the data of nodes to the right are > their parent's data.
   */
class BinarySearchTree {
    constructor() {
    /**
       * Just like the head of a linked list, this is the start of our tree which
       * branches downward from here.
       *
       * @type {BSTNode|null}
       */
    this.root = null;
    }

    /**
     * DFS Preorder: (CurrNode, Left, Right)
     * Converts this BST into an array following Depth First Search preorder.
     * Example on the fullTree var:
     * [25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90]
     * @param {Node} node The current node during the traversal of this tree.
     * @param {Array<number>} vals The data that has been visited so far.
     * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
     */
    toArrPreorder(node = this.root, vals = []) {
        if(node != null) {
            vals.push(node.data);
            this.toArrPreorder(node.left, vals);
            this.toArrPreorder(node.right, vals);
        }
        return vals;
    }

    /**
       * DFS Inorder: (Left, CurrNode, Right)
       * Converts this BST into an array following Depth First Search inorder.
       * See debugger call stack to help understand the recursion.
       * Example on the fullTree var:
       * [4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90]
       * @param {Node} node The current node during the traversal of this tree.
       * @param {Array<number>} vals The data that has been visited so far.
       * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
       */
    toArrInorder(node = this.root, vals = []) {
        if(node != null) {
            this.toArrInorder(node.left, vals);
            vals.push(node.data);
            this.toArrInorder(node.right, vals);
        }
        return vals;
    }

    /**
       * DFS Postorder (Left, Right, CurrNode)
       * Converts this BST into an array following Depth First Search postorder.
       * Example on the fullTree var:
       * [4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25]
       * @param {Node} node The current node during the traversal of this tree.
       * @param {Array<number>} vals The data that has been visited so far.
       * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
       */
    toArrPostorder(node = this.root, vals = []) {
        if(node != null){
            this.toArrPostorder(node.left, vals);
            vals.push(node.data);
            this.toArrPostorder(node.right, vals);
        }
        return vals;
    }
    

    /**
     * Inserts a new node with the given newVal in the right place to preserver
     * the order of this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} newVal The data to be added to a new node.
     * @returns {BinarySearchTree} This tree.
     */
    insert(newVal) {
        if(this.isEmpty()){
            this.root = new BSTNode(newVal);
            return this;
        }
        let current = this.root;
        while(current != null){
            if(newVal > current.data){
                if(current.right == null){
                    current.right = new BSTNode(newVal);
                    return this;
                }
                current = current.right;
            }
            if(newVal < current.data){
                if(current.left == null){
                    current.left = new BSTNode(newVal);
                    return this;
                }
                current = current.left;
            }
        }
    }

    /**
      * Inserts a new node with the given newVal in the right place to preserver
      * the order of this tree.
      * - Time: O(?).
      * - Space: O(?).
      * @param {number} newVal The data to be added to a new node.
      * @param {Node} curr The node that is currently accessed from the tree as
      *    the tree is being traversed.
      * @returns {BinarySearchTree} This tree.
      */
    insertRecursive(newVal, curr = this.root) {
        if(this.isEmpty()){
            this.root = new BSTNode(newVal);
            return this;
        }
        while(curr != null){
            if(newVal > curr.data){
                if(curr.right == null){
                    curr.right = new BSTNode(newVal);
                    return this;
                }
                return this.insertRecursive(newVal, curr = curr.right);
            }
            if(newVal < curr.data){
                if(curr.left == null){
                    curr.left = new BSTNode(newVal);
                    return this;
                }
                return this.insertRecursive(newVal, curr = curr.left);
            }
        }
    }

    /**
     * Determines if this tree contains the given searchVal.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} searchVal The number to search for in the node's data.
     * @returns {boolean} Indicates if the searchVal was found.
     */
    contains(searchVal) {
        let current = this.root;
        if(this.isEmpty()) {
            return false;
        }
        while(current != null) {
            if(searchVal === current.data) {
                return true;
            }
            else if(searchVal > current.data) {
                current = current.right;
            }
            else if(searchVal < current.data) {
                current = current.left;
            }
        }
        return false;
    }

    /**
     * Determines if this tree contains the given searchVal.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} searchVal The number to search for in the node's data.
     * @returns {boolean} Indicates if the searchVal was found.
     */
    containsRecursive(searchVal, current = this.root) {
        if(this.isEmpty()) {
            return false;
        }
        if(this.root == searchVal) {
            return true;
        }
        while(current != null) {
            if(searchVal > current.data) {
                this.containsRecursive(searchVal, current = current.right);
            }
            else if(searchVal < current.data) {
                this.containsRecursive(searchVal, current = current.left);
            }
            else if(searchVal === current.data) {
                return true;
            }
        }
        return false;
    }
    
    /**
     * Calculates the range (max - min) from the given startNode.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} startNode The node to start from to calculate the range.
     * @returns {number|null} The range of this tree or a sub tree depending on if the
     *    startNode is the root or not.
     */
    range(startNode = this.root) {
        let minVal = this.minRecursive();
        let maxVal = this.maxRecursive();
        let rangeval = maxVal - minVal;
        return rangeval;
    }

    /**
     * Determines if this tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {boolean} Indicates if this tree is empty.
     */
    isEmpty() {
        if(this.root === null) {
            return true;
        }
        else return false;
    }

    /**
     * Retrieves the smallest integer data from this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The smallest integer from this tree.
     */
    min(current = this.root) {
        if(this.isEmpty()) {
            return null;
        }
        if(current.left === null) {
            return current.data;
        }
        while(current.left != null) {
            current = current.left;
        }
        return current.data;
    }

    /**
     * Retrieves the smallest integer data from this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The smallest integer from this tree.
     */
    minRecursive(current = this.root) {
        if(this.isEmpty()) {
            return null;
        }
        if(current.left === null) {
            return current.data;
        }
        else if(current.left != null) {
            current = current.left;
            return this.minRecursive(current);
        }
        
    }

    /**
     * Retrieves the largest integer data from this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The largest integer from this tree.
     */
    max(current = this.root) {
        if(this.isEmpty()) {
            return null;
        }
        if(current.left === null) {
            return current.data;
        }
        while(current.right != null) {
            current = current.right;
        }
        return current.data;
    }

    /**
     * Retrieves the largest integer data from this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The largest integer from this tree.
     */
    maxRecursive(current = this.root) {
        if(this.isEmpty()) {
            return null;
        }
        if(current.right === null) {
            return current.data;
        }
        else if(current.right != null) {
            current = current.right;
            return this.maxRecursive(current);
        }
    }

    // Logs this tree horizontally with the root on the left.
    print(node = this.root, spaceCnt = 0, spaceIncr = 10) {
    if (!node) {
        return;
    }

    spaceCnt += spaceIncr;
    this.print(node.right, spaceCnt);

    console.log(
        " ".repeat(spaceCnt < spaceIncr ? 0 : spaceCnt - spaceIncr) +
        `${node.data}`
    );

    this.print(node.left, spaceCnt);
    }
}

const emptyTree = new BinarySearchTree();
const oneNodeTree = new BinarySearchTree();
oneNodeTree.root = new BSTNode(10);

/* twoLevelTree
     root
      10
    /   \
    5     15
*/
const twoLevelTree = new BinarySearchTree();
twoLevelTree.root = new BSTNode(10);
twoLevelTree.root.left = new BSTNode(5);
twoLevelTree.root.right = new BSTNode(15);

/* threeLevelTree 
        root
      10
    /   \
    5     15
/ \    / \
2   6  13  
*/
const threeLevelTree = new BinarySearchTree();
threeLevelTree.root = new BSTNode(10);
threeLevelTree.root.left = new BSTNode(5);
threeLevelTree.root.left.left = new BSTNode(2);
threeLevelTree.root.left.right = new BSTNode(6);
threeLevelTree.root.right = new BSTNode(15);
threeLevelTree.root.right.left = new BSTNode(13);

/* fullTree
                    root
                <-- 25 -->
            /            \
            15             50
        /    \         /    \
        10     22    35     70
    /   \   /  \    /  \   /  \
    4    12  18  24  31  44 66  90
*/
/***************** Uncomment after insert method is created. ****************/
const fullTree = new BinarySearchTree();
fullTree
fullTree.insert(25);
fullTree.insert(15);
fullTree.insert(10);
fullTree.insert(22);
fullTree.insert(4);
fullTree.insert(12);
fullTree.insert(18);
fullTree.insert(24);
fullTree.insert(50);
fullTree.insert(35);
fullTree.insert(70);
fullTree.insert(31);
fullTree.insert(44);
fullTree.insert(66);
fullTree.insert(90);
// fullTree.print();

console.log(fullTree.toArrPostorder());

// fullTree
// fullTree.insertRecursive(25);
// fullTree.insertRecursive(15);
// fullTree.insertRecursive(10);
// fullTree.insertRecursive(22);
// fullTree.insertRecursive(4);
// fullTree.insertRecursive(12);
// fullTree.insertRecursive(18);
// fullTree.insertRecursive(24);
// fullTree.insertRecursive(50);
// fullTree.insertRecursive(35);
// fullTree.insertRecursive(70);
// fullTree.insertRecursive(31);
// fullTree.insertRecursive(44);
// fullTree.insertRecursive(66);
// fullTree.insertRecursive(90);
// fullTree.print();


// const rootTree = new BinarySearchTree();
// rootTree.root = new BSTNode(13);

// console.log(threeLevelTree.contains(28));

// console.log(threeLevelTree.containsRecursive(2));

// console.log(threeLevelTree.max());
// console.log(threeLevelTree.range(5));