import { useEffect, useState } from "react"

function Help() {
    const [helpData, setHelpData] = useState("");

    const fetchHelpData = () => {
        fetch("/api/help")
            .then(response => {
                return response.json();
            })
            .then(data => {
                setHelpData(data.text);
            })
    }

    useEffect(() => {
        fetchHelpData()
    }, [])

    return <span>{helpData}</span>
}

export default Help