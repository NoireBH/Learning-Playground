import pfp from './assets/test img.png'

function Card(){
    return(
    <div>
        <img alt="purple image" src={pfp}>
        </img>
        <h1>This is a nice image</h1>
        <p>purple</p>
    </div>
    );
    
}

export default Card