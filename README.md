# ToDoList-API
learning how to implement Todo List API using C#

## TodoItem Schema

```
  TodoItem{
  id	integer($int64)
  name	string
  isComplete	boolean
  pending	boolean
  }
```

## Routes
### Method GET

  ```
  /api/TodoItems
  /api/TodoItems/{id}
  /api/TodoItems/pendings
  /api/TodoItems/completed
  ```
### Method POST
  ```
  /api/TodoItems
  ```
### Method PUT
  ```
  /api/TodoItems/{id}
  ```
### Method DELETE
  ```
  /api/TodoItems/{id}
  ```
