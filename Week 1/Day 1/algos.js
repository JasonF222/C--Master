// const node1 = {data: 1, next: null};
// const node2 = {data: 1, next: null};
// const node3 = {data: 1, next: null};

// node1.next = node2;
// node2.next = node3;

// console.log(node1);

// let currentNode = node1;

// while(currentNode.next != null) {
//     console.log(currentNode.data);
//     currentNode = currentNode.next;
// }
// console.log(currentNode.data);


/**
 * A class to represents a single item of a SinglyLinkedList that can be
 * linked to other Node instances to form a list of linked nodes.
 */
 class ListNode {
    /**
     * Constructs a new Node instance. Executed when the 'new' keyword is used.
     * @param {any} data The data to be added into this new instance of a Node.
     *    The data can be anything, just like an array can contain strings,
     *    numbers, objects, etc.
     * @returns {ListNode} A new Node instance is returned automatically without
     *    having to be explicitly written (implicit return).
     */
    constructor(data) {
      this.data = data;
      /**
       * This property is used to link this node to whichever node is next
       * in the list. By default, this new node is not linked to any other
       * nodes, so the setting / updating of this property will happen sometime
       * after this node is created.
       *
       * @type {ListNode|null}
       */
      this.next = null;
    }
  }
  


  /**
   * This class keeps track of the start (head) of the list and to store all the
   * functionality (methods) that each list should have.
   */
  class SinglyLinkedList {
    /**
     * Constructs a new instance of an empty linked list that inherits all the
     * methods.
     * @returns {SinglyLinkedList} The new list that is instantiated is implicitly
     *    returned without having to explicitly write "return".
     */
    constructor() {
      /** @type {ListNode|null} */
      this.head = null;
    }
  

        /**
     * Retrieves the data of the second to last node in this list.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {any} The data of the second to last node or null if there is no
     *    second to last node.
     */

      // Edge case for 1 node in list //

        secondToLast() {
          let runner = this.head;
          if(this.isEmpty()) {
            return null;
          }
          if(this.head.next == null) {
            return null;
          }
          while(runner.next.next != null) {
            runner = runner.next;
          }
          return runner.data;
          
        }

        /**
          * Removes the node that has the matching given val as it's data.
          * - Time: O(?).
          * - Space: O(?).
          * @param {any} val The value to compare to the node's data to find the
          *    node to be removed.
          * @returns {boolean} Indicates if a node was removed or not.
          */
        removeVal(val) {
          let runner = this.head;
          if(this.isEmpty()) {
            return false;
          }
        }
     
         // EXTRA
         /**
          * Inserts a new node before a node that has the given value as its data.
          * - Time: O(?).
          * - Space: O(?).
          * @param {any} newVal The value to use for the new node that is being added.
          * @param {any} targetVal The value to use to find the node that the newVal
          *    should be inserted in front of.
          * @returns {boolean} To indicate whether the node was pre-pended or not.
          */

        // check target.data and set newVal to be .next //

         prepend(newVal, targetVal) {}




        /**
     * Creates a new node with the given data and inserts that node at the front
     * of this list.
     * - Time: (?).
     * - Space: (?).
     * @param {any} data The data for the new node.
     * @returns {SinglyLinkedList} This list.
     */
        insertAtFront(data) {
          const newNode = new ListNode(data);
          newNode.next = this.head;
          this.head = newNode;
          return this;
        }



        
        /**
          * Removes the first node of this list.
          * - Time: (?).
          * - Space: (?).
          * @returns {any} The data from the removed node.
          */
        removeHead() {
          if(this.head == null) {
            return "List is empty!";
          }
          const newList = this.head.next;
          this.head = newList;
          return this;
        }


    /**
     * Removes the last node of this list.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {any} The data from the node that was removed.
     */

    // empty list, 1 node in list (change head to null, return data that was removed) //
    removeBack() {
      var runner = this.head;
      let removed = null;
      if(!this.head) {
        return null;
      }
      if(!this.next) {
        this.head = null;
        return removed.data;
      }
      while(runner.next.next) {
        if(runner.next.next == null) {
          removed = runner.next;
          runner.next = null;
          return removed.data;
        }
        runner = runner.next;
      }
    }
    
    /**
     * Determines whether or not the given search value exists in this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} val The data to search for in the nodes of this list.
     * @returns {boolean}
     */
    contains(val) {
      let runner = this.head;
      while(runner !== null) {
        if(runner.data == val) {
          return true;
        }
        runner = runner.next;
      }
      return false;
    }

    /**
     * Determines whether or not the given search value exists in this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} val The data to search for in the nodes of this list.
     * @param {?ListNode} current The current node during the traversal of this list
     *    or null when the end of the list has been reached.
     * @returns {boolean}
     */
    containsRecursive(val, current = this.head) {
      if(current.data == val) {
        return true;
      }
    }

    // EXTRA
    /**
     * Recursively finds the maximum integer data of the nodes in this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {ListNode} runner The start or current node during traversal, or null
     *    when the end of the list is reached.
     * @param {ListNode} maxNode Keeps track of the node that contains the current
     *    max integer as it's data.
     * @returns {?number} The max int or null if none.
     */
    recursiveMax(runner = this.head, maxNode = this.head) {}


         // EXTRA
        /**
          * Calculates the average of this list.
          * - Time: (?).
          * - Space: (?).
          * @returns {number|NaN} The average of the node's data.
          */
        average() {}


    /**
     * Determines if this list is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {boolean}
     */
    isEmpty()
    {
        if(this.head === null) {
            return true;
        }
        else return false;
    }

    /**
     * Creates a new node with the given data and inserts it at the back of
     * this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} data The data to be added to the new node.
     * @returns {SinglyLinkedList} This list.
     */
    insertAtBack(data) 
    {
        const newNode = new ListNode(data);
        if(this.isEmpty() === true) {
            this.head = newNode;
        }
        else {
            let currentNode = this.head;
            while(currentNode.next != null) {
                currentNode = currentNode.next;
            }
            currentNode.next = newNode;
        }
        return this;
    }

    /**
     * Creates a new node with the given data and inserts it at the back of
     * this list.
     * - Time: O(?).
     * - Space: O(?).
     * @param {any} data The data to be added to the new node.
     * @param {?ListNode} runner The current node during the traversal of this list
     *    or null when the end of the list has been reached.
     * @returns {SinglyLinkedList} This list.
     */
    insertAtBackRecursive(data, runner = this.head) {}
  
    /**
     * Calls insertAtBack on each item of the given array.
     * - Time: O(n * m) n = list length, m = arr.length.
     * - Space: O(1) constant.
     * @param {Array<any>} vals The data for each new node.
     * @returns {SinglyLinkedList} This list.
     */
    insertAtBackMany(vals) 
    {
      for (const item of vals) 
      {
        this.insertAtBack(item);
      }
      return this;
    }
  
    /**
     * Converts this list into an array containing the data of each node.
     * - Time: O(n) linear.
     * - Space: O(n).
     * @returns {Array<any>} An array of each node's data.
     */
    toArr() {
      const arr = [];
      let runner = this.head;
  
      while (runner) {
        arr.push(runner.data);
        runner = runner.next;
      }
      return arr;
    }
  }

  /******************************************************************* 
  Multiple test lists already constructed to test your methods on.
  Below commented code depends on insertAtBack method to be completed,
  after completing it, uncomment the code.
  */
  const newList = new SinglyLinkedList()
  const emptyList = new SinglyLinkedList();
  console.log(newList.insertAtBack("Hello").insertAtBack("Goodbye").insertAtBack("Friend").insertAtBack("Enemy").insertAtBack("Nuggie"));
  console.log(newList.secondToLast());

  // console.log(emptyList.removeHead());
  // const singleNodeList = new SinglyLinkedList().insertAtBackMany([1]);
  // const biNodeList = new SinglyLinkedList().insertAtBackMany([1, 2]);
  // const firstThreeList = new SinglyLinkedList().insertAtBackMany([1, 2, 3]);
  // const secondThreeList = new SinglyLinkedList().insertAtBackMany([4, 5, 6]);
  // const unorderedList = new SinglyLinkedList().insertAtBackMany([
  //   -5, -10, 4, -3, 6, 1, -7, -2,
  // ]);
//   console.log(firstThreeList);
  
  /* node 4 connects to node 1, back to head */
  // const perfectLoopList = new SinglyLinkedList().insertAtBackMany([1, 2, 3, 4]);
  // perfectLoopList.head.next.next.next = perfectLoopList.head;
  
  /* node 4 connects to node 2 */
  // const loopList = new SinglyLinkedList().insertAtBackMany([1, 2, 3, 4]);
  // loopList.head.next.next.next = loopList.head.next;
  
  // const sortedDupeList = new SinglyLinkedList().insertAtBackMany([
  //   1, 1, 1, 2, 3, 3, 4, 5, 5,
  // ]);
  
//   Print your list like so:
  // console.log(firstThreeList.toArr());

