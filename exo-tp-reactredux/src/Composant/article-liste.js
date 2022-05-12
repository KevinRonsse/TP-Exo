import {Article} from "./Article"

export const ListeArticle= (props) => {
    return(
        <div>
            {props.articles.map((a,i)=> (<Article article={a} key={i} addToArticle={props.addToArticle}></Article>))}
        </div>
    )
}