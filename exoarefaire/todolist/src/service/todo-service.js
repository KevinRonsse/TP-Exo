const todos =[

]

let id = 0

export const  getTodos = () => new Promise((resolve, reject) => {
    resolve(todos)
})

export const findTodoById= (id) => new Promise((resolve, reject) => {
    resolve(todos.find(t => t.id === id))
})

export const actionSearchTodos = (search) => new Promise((resolve, reject) => {
    resolve(todos.filter(t => t.title.includes(search)))
})

export const AddTodos = (todo) => {
    todos.push({id: ++id,...todo})
}

export const updateTodo = (id) =>{
    const todo = todos.find(t => t.id === id)
    if(todo != undefined){
        todo.status = !todo.statut
        return true
    }
    return false
}