import AppInstance from "./AppInstance";

const GetItems = async () => {
  const method = "items";

  return await AppInstance.get(method).then(({ data }) => {
    return data;
  });
};

export default GetItems;
