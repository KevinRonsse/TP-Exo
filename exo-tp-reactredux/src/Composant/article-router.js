import {Route,Routes} from 'react-router-dom';
import {CC} from "./cartCount2"
import {ListeArticle} from "./article-liste"
import { DetailArticle } from './Detail-Article';

export const ArticleRouter = (props) => {
    return(
        <Routes>
            <Route path='/' element={<ListeArticle articles={props.articles}></ListeArticle>}></Route>
            <Route path="/cartCount" element={<CC cart={props.cart} />}></Route>
            <Route path="/article/:id" element={<DetailArticle addToArticle={props.addToArticle} />}></Route>
        </Routes>
    )
}