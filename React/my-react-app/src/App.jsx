import Card from './Card.jsx'
import pfp from './assets/test img.png'
import pfpHalo from './assets/halo.jpg'
import pfpVergil from './assets/vergil.jpg'


function App() {
  return (
    <>
    <Card title="John" cardType="cardPurple" text="This is John" img={pfp} />
<Card title="Halo" cardType="cardGreen" text="This is Halo" img={pfpHalo} />
<Card title="Vergil" cardType="cardBlue" text="This is Vergil" img={pfpVergil} />

    </>
      
  )
}

export default App
