import pfp from './assets/test img.png'

function Card(){
    return(
    <div className='card'>
        <img alt="purple image" src={pfp}>
        </img>
        <h1 className='h1Center'>This is a nice image</h1>
        <p className='purpleText'>purple</p>
    </div>
    );
    
}

export default Card