import { Component } from "react"





export class AppTodo extends Component {
    constructor(props) {
        super(props)
        this.state = {
            todos: [],
            count: 0,
            searchTodo: [],

        }
    }

    addTodo = (todo) => {
        const newCount = this.state.count + 1
        const createTodo = { id: newCount, ...todo }
        this.setState({
            todos: [...this.state.todos, createTodo],
            count: newCount,
            searchTodo: []
        });
    }

    search = (val) => {
        const tpmSearchTodos = this.state.todos.filter(t => t.title.includes(val))
        if (tpmSearchTodos.length > 0) {
            this.setState({
                searchTodos: [...tpmSearchTodos]
            })
        }
    }

    update = (id) => {
        const tpmTodos = [...this.state.todos]
        tpmTodos.forEach(t => {
            if (t.id == id) {
                t.status = !t.status
            }
        })
        this.setState({ todos: [...tpmTodos], searchTodos: [] });
    }
    delete = (id) => {
        const tpmTodos = this.state.todos.filter(t => t.id != id)
        this.setState({ todos: [...tpmTodos], searchTodos: [] });
    }

    find = (id) => {
        return this.state.todos.find(t => t.id == id)
    }

    render(){
        return(
            <div>
                
            </div>
        )
    }
}