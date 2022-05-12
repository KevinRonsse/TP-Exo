import { Component } from "react"
import { CC } from "./cartCount2"
import { ListeArticle } from "./article-liste"
import { BrowserRouter } from "react-router-dom"
import { MenuBlog } from "./Menu-blog"
export class BlogApp extends Component {
    constructor(props) {
        super(props)
        this.state = {
            articles: [
                { id: 1, title: '', content: "" }
            ],
            cart: []

        }
    }
    findArticle = (id) => {

        return this.state.articles.find(p => p.id === id)
    }
    addToArticle = (id) => {

        const articles = this.state.articles.find(p => p.id === id)
        if (articles !== undefined) {
            this.setState({ cart: [...this.state.cart, { ...articles }] })
        }
    }
    render() {
        return (
            <div>
                <BrowserRouter>
                    <MenuBlog></MenuBlog>
                    <div>
                        <h1>Tous les articles</h1>
                        <CC totalArticle={this.state.cart.length}></CC>
                        <ListeArticle articles={this.state.articles}></ListeArticle>
                    </div>
                </BrowserRouter>
            </div>)

    }


}