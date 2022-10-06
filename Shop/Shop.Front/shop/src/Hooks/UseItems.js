import { useCallback, useState } from "react";
import GetItems from "Services/GetItems";

const UseItems = () => {
  const [itemsLoading, setItemsLoading] = useState(false);
  const [ItemsError, setItemsError] = useState(false);
  const [Items, setItems] = useState([]);
  const [Error, setError] = useState();

  const GetAllItems = useCallback(() => {
    setItemsLoading(true);
    GetItems()
      .then((data) => {
        setItems(data);
        setItemsError(false);
        setItemsLoading(false);
      })
      .catch((err) => {
        console.log(err);
        setError(err);
        setItemsError(true);
        setItemsLoading(false);
      });
  }, []);

  return {
    GetAllItems,
    itemsLoading,
    ItemsError,
    Error,
    Items,
  };
};

export default UseItems;
