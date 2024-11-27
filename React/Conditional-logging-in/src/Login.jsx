import propTypes from 'prop-types';

function Login(props){
    
    if(props.isLoggedIn){
      return  <h1 className="login-message">Hello {props.userName}</h1>
    }
    else{
       return <h1 className="guest-message">Please login to continue</h1>
    }
}

Login.proptypes = {
    isLoggedIn: propTypes.bool,
    userName: propTypes.string
}

Login.defaultProps = {
    isLoggedIn: false,
    userName: "Guest"
}

export default Login