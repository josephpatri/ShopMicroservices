import { Container, Row, Col } from "react-bootstrap";
import UseItems from "Hooks/UseItems";
import SingleItem from "./Items/SingleItem";
import { useEffect } from "react";

const Items = () => {
  const { GetAllItems, Items, itemsLoading } = UseItems();

  useEffect(() => {
    GetAllItems();
  }, [GetAllItems]);

  return (
    <Container>
      <Row>
        <Col>
          {!itemsLoading &&
            Items.map((i) => {
              return <SingleItem key={i} item={i}></SingleItem>;
            })}
        </Col>
      </Row>
    </Container>
  );
};

export default Items;
