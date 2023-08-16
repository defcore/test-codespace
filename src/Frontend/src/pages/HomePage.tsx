import { Button } from "@mui/material"
import { useState } from "react"

export default function HomePage() {
    const [count, setCount] = useState(0)
  
    return (
      <>
        <h1>Hello</h1>
        <div className="card">
          <Button variant="outlined" onClick={() => setCount((count) => count + 1)}>
            count is {count}
          </Button>
        </div>
      </>
    )
  }
  
  