
function Card(props){
    return(
    <div className={props.cardType}>
        <img className="cardImg" alt={`${props.textColour} image`} src={props.img} />
        <h1>{props.title}</h1>
        <p className={props.textColour}>{props.text}</p>
    </div>
    
    );
    
}

export default Card