import { useNavigate } from "react-router-dom"

export const withNavigate = (Composant)=> props => {
    const unavigate = useNavigate()

    return (
        <Composant {...props} navigate={unavigate} />
    )
}