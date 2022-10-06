import react from "react";
import Card from "react-bootstrap/Card";

const SingleItem = ({ item }) => {
  var dateObject = new Date(item.createdDate);  
  return (
    <Card className="text-center">
      <h1>{item.name}</h1>
      <h3>{item.description}</h3>
      <strong>{item.price}</strong>
      <code>{dateObject.toLocaleDateString()}</code>
    </Card>
  );
};

export default react.memo(SingleItem);
