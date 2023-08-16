import { Link } from "react-router-dom";
import Help from "../components/Help";

export default function HomePage() {
  return (
    <>
      <h1>Help</h1>
      <Help></Help>
      <Link to="/">Back to Home</Link>
    </>
  );
}
