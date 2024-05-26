package hu.bme.aut.android.recipes.feature.food

import androidx.room.Dao
import androidx.room.Delete
import androidx.room.Insert
import androidx.room.Query
import androidx.room.Update

@Dao
interface FoodItemDao {
    @Query("SELECT * FROM fooditem")
    fun getAll(): List<FoodItem>

    @Insert
    fun insert(shoppingItems: FoodItem): Long

    @Update
    fun update(shoppingItem: FoodItem)

    @Delete
    fun deleteItem(shoppingItem: FoodItem)
}