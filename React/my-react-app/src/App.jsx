import Card from './Card.jsx'
import pfp from './assets/test img.png'
import pfpHalo from './assets/halo.jpg'
import pfpVergil from './assets/vergil.jpg'


function App() {
  return (
    <>
    <Card title="Selen" cardType="cardPurple" text="Selen" img={pfp} />
<Card title="Halo" cardType="cardGreen" text="Halo" img={pfpHalo} />
<Card title="Vergil" cardType="cardBlue" text="Vergil" img={pfpVergil} />

    </>
      
  )
}

export default App
