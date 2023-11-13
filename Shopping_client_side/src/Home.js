import {
  Button,
  CircularProgress,
  FormControl,
  Grid,
  InputLabel,
  MenuItem,
  Select,
  TextField,
} from "@mui/material";
import axios from "axios";
import React, { useEffect, useState } from "react";

function Home() {
  const [Product, setProduct] = React.useState("");
  const [Category, setCategory] = React.useState(0);

  const [loading, setLoading] = React.useState(true);
  const [categoryList, setCategoryList] = React.useState([]);
  const [productInCategory, setProductInCategory] = React.useState([,]);

  const handelSetProduct = (event) => {
    setProduct(event.target.value);
  };
  const handelSetCategory = (event) => {
    setCategory(event.target.value);
  };
  const getProductInCategory = async () => {
    for (let index = 0; index < categoryList.length; index++) {
              const response = await axios.get(
        `https://localhost:7139/api/Product/categoryId/${categoryList[index].id}`
      );
      console.log(response.data);
      setProductInCategory(...[response.data]);
      setLoading(false);
    }
  };
  const getCategory = async () => {
    try {
      const response = await axios.get(
        `https://localhost:7139/api/Category/getbyBuyId/${1}`
      );
      setCategoryList(response.data);
      setLoading(false);
    } catch (error) {
      console.error(error);
    }
  };
  const send = async (e) => {
    e.preventDefault();
    let data = {
      name: Product,
      count: 1,
      categoryId: Category,
      category: null,
    };
    let response = await axios.post("https://localhost:7139/api/Product", data);
  };

  useEffect(() => {
    getCategory();
    getProductInCategory();
  }, []);

  return (
    <div>
      {loading ? (
        <>
          <CircularProgress />
        </>
      ) : (
        <>
          <h1>רשימת קניות</h1>
          <FormControl fullWidth>
            <InputLabel id="demo-simple-select-label">קטגוריה</InputLabel>
            <Grid item xs={1} sm={1}>
              <Select
                labelId="demo-simple-select-label"
                id="demo-simple-select"
                value={Category}
                label="קטגוריה"
                onChange={handelSetCategory}
              >
                {categoryList.map((category) => (
                  <MenuItem key={category.id} value={category.id}>
                    {category.name}
                  </MenuItem>
                ))}
              </Select>
            </Grid>
            <Grid item xs={12} sm={6}>
              <form>
                <TextField
                  dir="rtl"
                  required
                  fullWidth
                  id="product"
                  label="שם המוצר"
                  name="product"
                  onChange={handelSetProduct}
                />
              </form>
            </Grid>
            <Button variant="contained" onClick={send}>
              הוסף
            </Button>
          </FormControl>
          <h3>יש לאסוף את מוצרים אלו במחלקות המתאימות</h3>{" "}
        </>
      )}
    </div>
  );
}
export default Home;
